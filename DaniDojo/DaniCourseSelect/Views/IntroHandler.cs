using DaniDojo.Assets;
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

        public void Initialize(CourseSelectSceneController newParent)
        {
            parent = newParent;

            // Initialize the assets
            leftDoor = CourseSelectAssets.CreateDoor(this.gameObject, true);
            rightDoor = CourseSelectAssets.CreateDoor(this.gameObject, false);

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
