using System;
using UnityEngine;

namespace VRTKLite.Controllers.ButtonMaps
{
    public class ViveMap : ControllerButtonMap
    {
        public override Vector3 GetElementPosition(ControllerElements element)
        {
            return element switch
            {
                ControllerElements.AttachPoint => Vector3.zero,
                ControllerElements.Trigger => new Vector3(0, -.035f, -.05f),
                ControllerElements.GripLeft => new Vector3(-.02f, -.015f, .1f),
                ControllerElements.GripRight => new Vector3(.02f, -.015f, .1f),
                ControllerElements.Touchpad => new Vector3(0, .005f, -.05f),
                ControllerElements.ButtonOne => new Vector3(0, .005f, -.05f),
                ControllerElements.ButtonTwo => new Vector3(0, .005f, -.02f),
                ControllerElements.Body => Vector3.zero,
                ControllerElements.StartMenu => Vector3.zero,
                ControllerElements.SystemMenu => new Vector3(0, .005f, -.1f),
                _ => throw new ArgumentOutOfRangeException(nameof(element), element, null)
            };
        }
    }
}