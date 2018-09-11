using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Components
{
    /// <summary>
    /// Component for entities that move in two planes
    /// </summary>
    internal interface IPosition2D
    {
        Vector2 Position
        {
            get;
            set;
        }

        Vector3 Forward
        {
            get;
            set;
        }
    }
}

