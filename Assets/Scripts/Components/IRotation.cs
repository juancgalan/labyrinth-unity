using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace Components
{
    /// <summary>
    /// Component that rotates in one axis
    /// </summary>
    internal interface IHorizontalRotation
    {
        Vector3 HorizontalAxis { get; set; }
        float HorizontalRotation { get; set; }
        float HorizontalRotationSpeed { get; set; }
    }
}

