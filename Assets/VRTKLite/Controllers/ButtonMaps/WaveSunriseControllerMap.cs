using System;
using UnityEngine;

namespace VRTKLite.Controllers.ButtonMaps
{
    public class WaveSunriseControllerMap : ControllerButtonMap
    {
        private readonly bool isRight;
        public WaveSunriseControllerMap(GameObject controller, bool isRight)
        {
            controllerModel = controller;
            this.isRight = isRight;
        }
        
        protected override string ElementPath(ControllerElements element)
        {
            return element switch
            {
                ControllerElements.Trigger => "__CM__TriggerKey",
                ControllerElements.Touchpad => "__CM__Thumbstick",
                ControllerElements.ButtonOne => isRight ? "__CM__ButtonA" : "__CM__ButtonX",
                ControllerElements.ButtonTwo => isRight ? "__CM__ButtonB" : "__CM__ButtonY",
                ControllerElements.SystemMenu => "__CM__HomeButton",
                ControllerElements.Body => "__CM__Body",
                ControllerElements.StartMenu => "__CM__AppButton",
                ControllerElements.GripLeft => "__CM__Grip",
                ControllerElements.GripRight => "__CM__Grip",
                ControllerElements.AttachPoint => null,
                _ => throw new ArgumentOutOfRangeException(nameof(element), element, null)
            };
        }
    }
}