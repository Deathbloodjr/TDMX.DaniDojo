using DaniDojo.DaniCourseSelect.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DaniDojo.DaniCourseSelect.Views
{
    internal class ConfirmationDialog : MonoBehaviour
    {
#if IL2CPP
        static ConfirmationDialog() => ClassInjector.RegisterTypeInIl2Cpp<ConfirmationDialog>();
#endif
        private CourseSelectSceneController parent;


        public void Initialize(CourseSelectSceneController newParent)
        {
            parent = newParent;
        }

    }
}
