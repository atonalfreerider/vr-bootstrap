using System;
using UnityEngine;

namespace VRTKLite.Controllers.ButtonMaps
{
    public class KnucklesMap : ControllerButtonMap
    {
        public override Vector3 GetElementPosition(ControllerElements element)
        {
            switch (element)
            {
                case ControllerElements.AttachPoint:
                    return Vector3.zero;
                case ControllerElements.Trigger:
                    return new Vector3(0, -.045f, -.05f);
                case ControllerElements.GripLeft:
                    return new Vector3(0, -.025f, -.1f);
                case ControllerElements.GripRight:
                    return new Vector3(0, -.025f, -.1f);
                // right hand only
                case ControllerElements.Touchpad:
                    return new Vector3(-.006f, .002f, -.05f);
                case ControllerElements.ButtonOne:
                    return new Vector3(-.02f, .006f, -.06f);
                case ControllerElements.ButtonTwo:
                    return new Vector3(-.02f, .0035f, -.05f);
                
                case ControllerElements.Body:
                    return Vector3.zero;
                case ControllerElements.StartMenu:
                    return Vector3.zero;
                case ControllerElements.SystemMenu:
                    return new Vector3(-.01f, .01f, -.065f);
                default:
                    throw new ArgumentOutOfRangeException(nameof(element), element, null);
            }
        }
    }
}