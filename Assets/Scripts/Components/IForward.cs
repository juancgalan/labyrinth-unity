using Unity.Collections;
using UnityEngine;

namespace Components
{
    public interface IForward2D
    {
        float ForwardStep { get; set; }
        float ForwardSpeed { get; set; }
        Vector3 Forward { get; set; }
    }
}