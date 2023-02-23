using System;
using UnityEngine;

namespace VRTKLite.Controllers.ButtonMaps
{
    public class KnucklesMap : ControllerButtonMap
    {
        public override Vector3 GetElementPosition(ControllerElements element)
        {
            return element switch
            {
                ControllerElements.AttachPoint => new Vector3(-0.0006f, -0.0042f, 0.0931f),
                ControllerElements.Trigger => new Vector3(-0.0065f, -0.0347f, 0.0504f),
                ControllerElements.GripLeft => new Vector3(0, -.025f, -.1f),
                ControllerElements.GripRight => new Vector3(0, -.025f, -.1f),
                // right hand only
                ControllerElements.Touchpad => new Vector3(0.0139f, .0015f, 0.0515f),
                ControllerElements.ButtonOne => new Vector3(-0.01895f, 0.00888f, 0.04f),
                ControllerElements.ButtonTwo => new Vector3(-0.02156f, 0.00403f, 0.048f),
                ControllerElements.Body => new Vector3(-0.0006f, -0.0042f, 0.0931f),
                ControllerElements.StartMenu => Vector3.zero,
                ControllerElements.SystemMenu => new Vector3(-.01f, .01f, -.065f),
                _ => throw new ArgumentOutOfRangeException(nameof(element), element, null)
            };
        }
    }
}