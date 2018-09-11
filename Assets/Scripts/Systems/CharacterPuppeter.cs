using System.Collections;
using System.Collections.Generic;
using Components;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

namespace Systems {
	
    public class CharacterPuppeter : MonoBehaviour
    {
	    private ICharacter _character;
	    private const float Delta = 0.0001f;

	    // Use this for initialization
        private void Start ()
        {
	        _character = GetComponent<ICharacter>();
        }
        
        // Update is called once per frame
        private void Update ()
        {
	        _character.ForwardStep = Input.GetAxis("Vertical");
	        _character.StrifeStep = Input.GetAxis("Horizontal");
	        _character.HorizontalRotation = Input.GetAxis("Mouse X");
	        _character.VerticalRotation = Input.GetAxis("Mouse Y");
        }

	    private void FixedUpdate()
	    {
		    MoveForward();
		    Strife();
		    RotateHorizontal();
		    RotateVertical();
	    }

	    private void MoveForward()
	    {
		    if (Mathf.Abs(_character.ForwardStep) <= Delta) return;
		    var displacement = _character.Forward * _character.ForwardStep * _character.ForwardSpeed * Time.deltaTime;
		    _character.Rigidbody.MovePosition(_character.Transform.position + displacement);
	    }

	    private void Strife()
	    {
		    if (Mathf.Abs(_character.StrifeStep) <= Delta) return;
		    var displacement = _character.StrifeDirection * _character.StrifeStep * _character.StrifeSpeed * Time.deltaTime;
		    _character.Rigidbody.MovePosition(_character.Transform.position + displacement);
	    }

	    private void RotateHorizontal()
	    {
		    if (Mathf.Abs(_character.HorizontalRotation) <= Delta) return;
		    var rotation = _character.HorizontalRotation * _character.HorizontalRotationSpeed * Time.deltaTime;
		    _character.CharacterCamera.Rotate(_character.HorizontalAxis, rotation);
	    }
	    
	    private void RotateVertical()
	    {
		    Debug.Log(_character.VerticalRotation);
		    if (Mathf.Abs(_character.VerticalRotation) <= Delta) return;
		    var rotation = _character.VerticalRotation * _character.VerticalRotationSpeed * Time.deltaTime;
		    _character.CharacterCamera.Rotate(_character.VerticalAxis, -rotation);
	    }
    }
	
}
