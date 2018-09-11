using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Components
{
	internal interface ICharacter : IPhysics, IForward2D, IHorizontalRotation, ITransform, IStrife2D, IVerticalRotation,
		ICamera
	{
	}
}