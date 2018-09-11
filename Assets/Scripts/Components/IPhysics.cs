using UnityEngine;

namespace Components
{
    /// <summary>
    /// Component that has physics enabled
    /// </summary>
    internal interface IPhysics
    {
        Rigidbody Rigidbody
        {
            get;
        }
    }
}

