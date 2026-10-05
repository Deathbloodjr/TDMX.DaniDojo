using DaniDojo.Assets;
using DaniDojo.DaniCourseSelect.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DaniDojo.DaniCourseSelect
{
    public enum CourseSelectState
    {
        Intro,
        SelectingCourse,
        Confirmation,
        OptionsMenu
    }

    internal class CourseSelectSceneController : MonoBehaviour
    {
#if IL2CPP
        static CourseSelectSceneController() => ClassInjector.RegisterTypeInIl2Cpp<CourseSelectSceneController>();
#endif

        private IntroHandler introHandler;
        private SelectionManager selectionManager;
        private ConfirmationDialog confirmationDialog;

        private CourseSelectState currentState;

        private void Start()
        {
            InitializeAssets();


            ChangeState(CourseSelectState.Intro);


            introHandler.StartIntro();
        }

        private void InitializeAssets()
        {
            var canvas = AssetUtility.CreateEmptyObject(null, "BgCanvas", Vector2.zero);
            AssetUtility.AddCanvasComponent(canvas);
            introHandler = canvas.AddComponent<IntroHandler>();
            introHandler.Initialize(this);
        }

        private void Update()
        {
            // Input is routed ONLY to the active state handler
            switch (currentState)
            {
                case CourseSelectState.Intro:
                    if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Cancel"))
                    {
                        //introHandler.SkipIntro();
                    }
                    break;

                //case CourseSelectState.SelectingCourse:
                //    selectionManager.HandleInput();
                //    break;

                //case CourseSelectState.Confirmation:
                //    confirmationDialog.HandleInput();
                //    break;
            }
        }

        public void ChangeState(CourseSelectState newState)
        {
            currentState = newState;
            //selectionManager.SetInputActive(newState == CourseSelectState.SelectingCourse);
            //confirmationDialog.SetVisible(newState == CourseSelectState.Confirmation);
        }

        public void StartSelectingCourseIntro()
        {
            ChangeState(CourseSelectState.SelectingCourse);
            selectionManager.StartTopCourseDropDown();
        }
    }
}
