using UnityEngine;

namespace Components
{
    public interface IVerticalRotation
    {
        Vector3 VerticalAxis { get; set; }
        float VerticalRotation { get; set; }
        float VerticalRotationSpeed { get; set; }
    }
}