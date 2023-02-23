using System;
using UnityEngine;

namespace VRTKLite.Controllers.ButtonMaps
{
    public class CosmosMap : ControllerButtonMap
    {
        public override Vector3 GetElementPosition(ControllerElements element)
        {
            return element switch
            {
                ControllerElements.AttachPoint => Vector3.zero,
                ControllerElements.Trigger => new Vector3(0, -.056f, -.056f),
                ControllerElements.GripLeft => new Vector3(0, -.025f, -.1f),
                ControllerElements.GripRight => new Vector3(0, -.025f, -.1f),
                // right hand only
                ControllerElements.Touchpad => new Vector3(-.006f, .002f, -.05f),
                ControllerElements.ButtonOne => new Vector3(-.013f, .006f, -.06f),
                ControllerElements.ButtonTwo => new Vector3(-.017f, .003f, -.05f),
                ControllerElements.Body => Vector3.zero,
                ControllerElements.StartMenu => Vector3.zero,
                ControllerElements.SystemMenu => new Vector3(.006f, .0006f, -.06f),
                _ => throw new ArgumentOutOfRangeException(nameof(element), element, null)
            };
        }
    }
}