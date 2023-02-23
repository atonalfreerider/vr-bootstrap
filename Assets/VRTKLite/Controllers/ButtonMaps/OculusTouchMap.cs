using System;
using UnityEngine;

namespace VRTKLite.Controllers.ButtonMaps
{
    public class OculusTouchMap : ControllerButtonMap
    {
        readonly bool isRight;

        string Prefix => !isRight
            ? "lctrl"
            : "rctrl";

        public OculusTouchMap(GameObject controller, bool isRight)
        {
            controllerModel = controller;
            this.isRight = isRight;
        }

        protected override string ElementPath(ControllerElements element)
        {
            return element switch
            {
                ControllerElements.AttachPoint => null,
                ControllerElements.Trigger => $"{Prefix}:b_trigger",
                ControllerElements.GripLeft => $"{Prefix}:b_hold",
                ControllerElements.GripRight => $"{Prefix}:b_hold",
                ControllerElements.Touchpad => $"{Prefix}:b_stick",
                ControllerElements.ButtonOne => $"{Prefix}:b_button01",
                ControllerElements.ButtonTwo => $"{Prefix}:b_button02",
                ControllerElements.Body => null,
                ControllerElements.StartMenu => null,
                ControllerElements.SystemMenu => $"{Prefix}:b_button03",
                _ => throw new ArgumentOutOfRangeException(nameof(element), element, null)
            };
        }
    }
}