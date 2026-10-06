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

        List<GameObject> textImages = new List<GameObject>();

        public void Initialize(CourseSelectSceneController newParent)
        {
            parent = newParent;

            // Initialize the assets
            leftDoor = CourseSelectAssets.CreateDoor(this.gameObject, new Vector2(-600, 0), true);
            rightDoor = CourseSelectAssets.CreateDoor(this.gameObject, new Vector2(600, 0), false);

            for (int i = 0; i < 4; i++)
            {
                Vector2 position = i switch
                {
                    0 => new Vector2(-505, 285),
                    1 => new Vector2(460, 285),
                    2 => new Vector2(-505, -225),
                    3 => new Vector2(460, -225),
                }
                ;
                textImages.Add(CourseSelectAssets.CreateIntroText(this.gameObject, position, i));
            }
        }


        public void StartIntro()
        {
            introAnimation = Plugin.Instance.StartCoroutine(PlayIntro());
        }

        private void SnapIntroToEndPosition()
        {

        }

        public void StopIntro()
        {
            ModLogger.Log("Stop Course Select Intro Animation", LogType.Debug);
            if (introAnimation != null)
            {
                Plugin.Instance.StopCoroutine(introAnimation);
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

                yield return new WaitForSeconds(2f);

                for (int i = 0; i < textImages.Count; i++)
                {
                    var scaleAnim = Plugin.Instance.StartCoroutine(textImages[i].transform.ScaleRoutine(Vector3.one, 1f / 6f));
                    var alphaAnim = Plugin.Instance.StartCoroutine(textImages[i].GetComponent<CanvasGroup>().FadeRoutine(1f, 1f / 6f));

                    yield return scaleAnim;
                    yield return alphaAnim;

                    // Minor movement and sound goes here
                    yield return new WaitForSeconds(4f / 60f);

                    // Wait for next image to be done
                    yield return new WaitForSeconds(13f / 60f);
                }

            }
            finally
            {
                SnapIntroToEndPosition();
                introAnimation = null;
                parent.StartSelectingCourseIntro();
            }
            yield return null;
        }

        
    }
}
