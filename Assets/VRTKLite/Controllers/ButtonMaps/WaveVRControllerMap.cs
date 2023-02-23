using System;
using UnityEngine;

namespace VRTKLite.Controllers.ButtonMaps
{
    public class WaveVRControllerMap : ControllerButtonMap
    {
        public WaveVRControllerMap(GameObject controller)
        {
            controllerModel = controller;
        }
        
        protected override string ElementPath(ControllerElements element)
        {
            return element switch
            {
                ControllerElements.Trigger => "Trigger",
                ControllerElements.ButtonOne => "TouchPad",
                ControllerElements.Touchpad => "TouchPad",
                ControllerElements.ButtonTwo => "AppButton",
                ControllerElements.SystemMenu => "HomeButton",
                ControllerElements.Body => "Body",
                ControllerElements.GripLeft => "Grip",
                ControllerElements.GripRight => "Grip",
                ControllerElements.AttachPoint => null,
                ControllerElements.StartMenu => null,
                _ => throw new ArgumentOutOfRangeException(nameof(element), element, null)
            };
        }
    }
}