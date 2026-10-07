using DaniDojo.Assets;
using DaniDojo.DaniCourseSelect.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
            if (TaikoSingletonMonoBehaviour<InputGuide>.Instance.IsEnableGuide())
            {
                TaikoSingletonMonoBehaviour<InputGuide>.Instance.DisableGuide();
            }

            InitializeAssets();




        }

        private void InitializeAssets()
        {
            var selectionCanvas = AssetUtility.CreateRootCanvas("SelectionCanvas");
            var selectionManagerObject = AssetUtility.CreateUIContainer(selectionCanvas.gameObject, "SelectionManager");
            selectionManager = selectionManagerObject.AddComponent<SelectionManager>();
            selectionManager.Initialize(this);

            var introCanvas = AssetUtility.CreateRootCanvas("IntroCanvas");
            var introHandlerObject = AssetUtility.CreateUIContainer(introCanvas.gameObject, "IntroHandler");
            introHandler = introHandlerObject.AddComponent<IntroHandler>();
            introHandler.Initialize(this);

            var confirmationDialogCanvas = AssetUtility.CreateRootCanvas("ConfirmationDialogCanvas");
            var confirmationDialogObject = AssetUtility.CreateUIContainer(confirmationDialogCanvas.gameObject, "ConfirmationDialog");
            confirmationDialog = confirmationDialogObject.AddComponent<ConfirmationDialog>();
            confirmationDialog.Initialize(this);

            ChangeState(CourseSelectState.Intro);
            introHandler.StartIntro();
        }

        private void Update()
        {
            if (TaikoSingletonMonoBehaviour<InputGuide>.Instance.IsEnableGuide())
            {
                TaikoSingletonMonoBehaviour<InputGuide>.Instance.DisableGuide();
            }

            // Input is routed ONLY to the active state handler
            switch (currentState)
            {
                // I don't think Intro should get any input
                // It would only be used to skip the animation, and I don't plan on allowing it to be skipped
                // Even though there's really no downside to allowing it to be skipped, whatever
                //case CourseSelectState.Intro:
                //    if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Cancel"))
                //    {
                //        //introHandler.SkipIntro();
                //    }
                //    break;

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
