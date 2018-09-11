using Unity.Collections;
using UnityEngine;

namespace Components
{
    public interface IStrife2D
    {
        Vector3 StrifeDirection { get; }
        float StrifeSpeed { get; set; }
        float StrifeStep { get; set; }
    }
}