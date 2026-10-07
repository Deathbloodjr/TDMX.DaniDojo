using DaniDojo.Assets;
using DaniDojo.Assets.Animation;
using DaniDojo.Assets.Audio;
using DaniDojo.DaniCourseSelect.Assets;
using DaniDojo.Data;
using DaniDojo.ResultsScreen;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace DaniDojo.DaniCourseSelect.Views
{
    internal class IntroHandler : MonoBehaviour
    {
#if IL2CPP
        static IntroHandler() => ClassInjector.RegisterTypeInIl2Cpp<IntroHandler>();
#endif

        private CourseSelectSceneController parent;
        private Coroutine introAnimation;

        GameObject leftDoor;
        GameObject rightDoor;
        GameObject background;

        List<GameObject> textImages = new List<GameObject>();
        private readonly List<Vector2> baseTextPositions = new List<Vector2>
        {
            new Vector2(-505, 285),  // TopLeft
            new Vector2(460, 285),   // TopRight
            new Vector2(-505, -225), // BotLeft
            new Vector2(460, -225)   // BotRight
        };

        // Shake offsets for movements 1..3 relative to base position
        private static readonly Vector2[][] TextShakeOffsets = new Vector2[][]
        {
            // Index 0: TopLeft
            new[] { new Vector2(0, -10), new Vector2(-10, 0), new Vector2(10, 0) },
            // Index 1: TopRight
            new[] { new Vector2(0, -10), new Vector2(-10, 0), new Vector2(10, 0) },
            // Index 2: BotLeft
            new[] { new Vector2(-10, 0), new Vector2(0, -10), new Vector2(0, 10) },
            // Index 3: BotRight
            new[] { new Vector2(10, 0),  new Vector2(0, 10),  new Vector2(0, -10) }
        };

        public void Initialize(CourseSelectSceneController newParent)
        {
            parent = newParent;

            // Initialize the assets
            background = CourseSelectAssets.CreateBackground(this.gameObject);
            rightDoor = CourseSelectAssets.CreateDoor(this.gameObject, new Vector2(600, 0), isLeftDoor: false);
            leftDoor = CourseSelectAssets.CreateDoor(this.gameObject, new Vector2(-600, 0), isLeftDoor: true);

            for (int i = 0; i < 4; i++)
            {
                textImages.Add(CourseSelectAssets.CreateIntroText(gameObject, baseTextPositions[i], i));
            }
        }


        public void StartIntro()
        {
            introAnimation = StartCoroutine(PlayIntro());
        }

        private void SnapIntroToEndPosition()
        {
            if (leftDoor != null)
            {
                AssetUtility.SetPosition(leftDoor, new Vector2(-1600, 0));
                AssetUtility.SetScale(leftDoor, new Vector3(-1f, 1f, 1f));
            }
            if (rightDoor != null)
            {
                AssetUtility.SetPosition(rightDoor, new Vector2(1600, 0));
                AssetUtility.SetScale(rightDoor, Vector3.one);
            }

            foreach (var textObj in textImages)
            {
                if (textObj != null) AssetUtility.SetAlpha(textObj, 0f);
            }

            if (background != null)
            {
                AssetUtility.SetScale(background, new Vector3(1.25f, 1.25f, 1f));
                AssetUtility.SetImageColor(background, Color.white);
            }
        }

        public void StopIntro()
        {
            ModLogger.Log("Stop Course Select Intro Animation", LogType.Debug);
            if (introAnimation != null)
            {
                StopCoroutine(introAnimation);
            }
        }

        public bool IsInIntro()
        {
            return introAnimation != null;
        }

        private IEnumerator PlayIntro()
        {
            try
            {
                ModLogger.Log("DaniDojo Course Select Intro Animation", LogType.Debug);

                // Wait for the loading screen to fully fade away, and this scene to fully come into view
                // 2f is just a randomly guessed time
                yield return new WaitForSeconds(2f);

                // Reference ran at 60fps
                float stepFrameTime = 1f / 60f;

                for (int i = 0; i < textImages.Count; i++)
                {
                    float textDuration = 1f / 6f;
                    StartCoroutine(textImages[i].transform.ScaleRoutine(Vector3.one, textDuration));
                    StartCoroutine(textImages[i].GetComponent<CanvasGroup>().FadeRoutine(1f, textDuration));

                    yield return new WaitForSeconds(textDuration);
                    DaniSoundManager.PlaySound(DaniDojoAudio.SeDaniOdaiIntro);

                    // 4-step impact bounce (shake)
                    float[] doorYSteps = { -10f, 10f, -6f, 0f };
                    for (int step = 0; step < 4; step++)
                    {
                        float doorY = doorYSteps[step];
                        StartCoroutine(leftDoor.transform.MovementRoutine(new Vector2(-600, doorY), stepFrameTime));
                        StartCoroutine(rightDoor.transform.MovementRoutine(new Vector2(600, doorY), stepFrameTime));

                        Vector2 textPos = GetTextShakePosition(i, step + 1);
                        StartCoroutine(textImages[i].transform.MovementRoutine(textPos, stepFrameTime));

                        yield return new WaitForSeconds(stepFrameTime);
                    }

                    yield return new WaitForSeconds(stepFrameTime * 13);
                }

                // Wait for next animation
                yield return new WaitForSeconds(stepFrameTime * 13);

                // Next, text fades out and doors open
                float duration = stepFrameTime * 3;
                for (int i = 0; i < textImages.Count; i++)
                {
                    var alphaAnim = StartCoroutine(textImages[i].FadeRoutine(0f, duration));
                }
                // doors go inward for 5 frames

                duration = stepFrameTime * 5;
                StartCoroutine(leftDoor.transform.ScaleRoutine(new Vector3(-1.1f, 1), duration));
                StartCoroutine(rightDoor.transform.ScaleRoutine(new Vector3(1.1f, 1), duration));

                StartCoroutine(leftDoor.transform.MovementRoutine(new Vector2(-564, 0), duration));
                StartCoroutine(rightDoor.transform.MovementRoutine(new Vector2(564, 0), duration));

                yield return new WaitForSeconds(duration);

                // doors go outward for 13 frames at an even rate
                // I didn't check exact details for these yet, but they should be mostly correct
                duration = stepFrameTime * 13;
                StartCoroutine(leftDoor.transform.ScaleRoutine(new Vector3(-1f, 1), duration));
                StartCoroutine(rightDoor.transform.ScaleRoutine(new Vector3(1f, 1), duration));

                StartCoroutine(leftDoor.transform.MovementRoutine(new Vector2(-1600, 0), duration));
                StartCoroutine(rightDoor.transform.MovementRoutine(new Vector2(1600, 0), duration));

                StartCoroutine(leftDoor.GetComponent<Image>().ColorRoutine(Color.white, duration));
                StartCoroutine(rightDoor.GetComponent<Image>().ColorRoutine(Color.white, duration));

                StartCoroutine(background.transform.ScaleRoutine(new Vector3(1.25f, 1.25f), 1));
                StartCoroutine(background.GetComponent<Image>().ColorRoutine(Color.white, 1));

                // 45 frames after doors are fully invisible, the background settles in to its final position
                // It slows down over time



                yield return new WaitForSeconds(1);
                // Before doors are completely open, they become brighter
                // Behind the doors is the BG.png scene
                // The BG scene begins zoomed out and darker, before progressing to its expected size, and its typical brightness
                // Once it's at this point, the intro is complete and we move on to SelectionManager


            }
            finally
            {
                SnapIntroToEndPosition();
                introAnimation = null;
                parent.StartSelectingCourseIntro();
            }
            yield return null;
        }

        private Vector2 GetTextShakePosition(int textIndex, int movementStep)
        {
            Vector2 basePos = baseTextPositions[textIndex];
            if (movementStep >= 1 && movementStep <= 3)
            {
                return basePos + TextShakeOffsets[textIndex][movementStep - 1];
            }
            return basePos; // Step 4 or default returns to origin
        }
    }
}
