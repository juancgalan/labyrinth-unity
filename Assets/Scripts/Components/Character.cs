using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace Components
{
	/// <inheritdoc />
	/// <summary>
	/// Class contains the componet for a character that can be moved in 2 planes and rotated on one axis. Intended for
	/// FPS style camera.
	/// </summary>
	public sealed class Character : MonoBehaviour, ICharacter
	{
		// Editor variables
		public Vector3 HorizontalRotationAxis = Vector3.up;
		public Vector3 VerticalRotationAxis = Vector3.right;
		public Vector3 ForwardDirection = Vector3.forward;
		public float InitialSpeed = 1f;
		public float SpeedForStrife = 0.5f;
		public float RotationSpeed = 10f;
		
		// Interface implementation 
		public Transform Transform { get; private set; }
		public Rigidbody Rigidbody { get; private set; }
		public float ForwardStep { get; set; }
		public Vector3 Forward { get; set; }
		public Vector3 StrifeDirection { get; private set; }
		public float StrifeSpeed { get; set; }
		public float StrifeStep { get; set; }
		public float ForwardSpeed { get; set; }
		public Vector3 HorizontalAxis { get; set; }
		public float HorizontalRotation { get; set; }
		public float HorizontalRotationSpeed { get; set; }
		public Vector3 VerticalAxis { get; set; }
		public float VerticalRotation { get; set; }
		public float VerticalRotationSpeed { get; set; }
		public Transform CharacterCamera { get; private set; }

		/// <summary>
		/// Initialize all members of the component
		/// </summary>
		private void Start()
		{
			Rigidbody = GetComponent<Rigidbody>();
			ForwardStep = 0;
			HorizontalAxis = -HorizontalRotationAxis.normalized;
			VerticalAxis = VerticalRotationAxis.normalized;
			HorizontalRotation = 0;
			VerticalRotation = 0;
			Transform = transform;
			ForwardSpeed = InitialSpeed;
			Forward = ForwardDirection;
			StrifeDirection = Vector3.Cross(HorizontalAxis, Forward);
			StrifeSpeed = SpeedForStrife;
			StrifeStep = 0;
			HorizontalRotationSpeed = RotationSpeed;
			VerticalRotationSpeed = RotationSpeed;
			Debug.Log(transform.childCount);
			CharacterCamera = transform.GetChild(0);
		}

	}
}