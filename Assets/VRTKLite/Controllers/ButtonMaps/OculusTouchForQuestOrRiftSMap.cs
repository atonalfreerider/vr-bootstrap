using System;
using UnityEngine;

namespace VRTKLite.Controllers.ButtonMaps
{
    public class OculusTouchForQuestOrRiftSMap : ControllerButtonMap
    {
        public override Vector3 GetElementPosition(ControllerElements element)
        {
            return element switch
            {
                ControllerElements.AttachPoint => Vector3.zero,
                ControllerElements.Trigger => new Vector3(0, -.01f, .02f),
                ControllerElements.GripLeft => new Vector3(0, -.02f, -.03f),
                ControllerElements.GripRight => new Vector3(0, -.02f, -.03f),
                ControllerElements.Touchpad =>
                    // this is for right touch (left is -0.0185f
                    new Vector3(.0185f, 0, .0085f),
                ControllerElements.ButtonOne => new Vector3(0, 0, -.01f),
                ControllerElements.ButtonTwo => new Vector3(0, 0, .01f),
                ControllerElements.Body => Vector3.zero,
                ControllerElements.StartMenu => Vector3.zero,
                ControllerElements.SystemMenu => new Vector3(0, 0, -.0265f),
                _ => throw new ArgumentOutOfRangeException(nameof(element), element, null)
            };
        }
    }
}