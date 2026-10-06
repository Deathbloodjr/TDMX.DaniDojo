using DaniDojo.DaniCourseSelect.Assets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DaniDojo.DaniCourseSelect.Views
{
    internal class SelectionManager : MonoBehaviour
    {
#if IL2CPP
        static SelectionManager() => ClassInjector.RegisterTypeInIl2Cpp<SelectionManager>();
#endif

        private CourseSelectSceneController parent;
        private Coroutine topCourseDropDownAnimation;


        public void Initialize(CourseSelectSceneController newParent)
        {
            parent = newParent;
        }

        public void StartTopCourseDropDown()
        {
            topCourseDropDownAnimation = Plugin.Instance.StartCoroutine(PlayTopCourseDropDown());
        }

        private void SnapTopCoursesToEndPosition()
        {

        }

        public void StopTopCourseDropDown()
        {
            ModLogger.Log("Stop Course Select Top Course Drop Down Animation", LogType.Debug);
            if (topCourseDropDownAnimation != null)
            {
                Plugin.Instance.StopCoroutine(topCourseDropDownAnimation);
            }
        }

        public bool IsInTopCourseDropDown()
        {
            return topCourseDropDownAnimation != null;
        }

        private IEnumerator PlayTopCourseDropDown()
        {
            try
            {
                ModLogger.Log("DaniDojo Course Select Top Course Drop Down Animation", LogType.Debug);

            }
            catch (Exception)
            {
                SnapTopCoursesToEndPosition();
                topCourseDropDownAnimation = null;
            }
            yield return null;
        }
    }
}
