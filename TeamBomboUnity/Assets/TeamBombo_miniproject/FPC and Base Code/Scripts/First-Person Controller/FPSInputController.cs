using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//adaptation of included Unity JavaScript component in C# by xadhoom
//reference: http://forum.unity3d.com/threads/64378-CharacterMotor-FPSInputController-PlatformInputController-in-C

// Require a character controller to be attached to the same game object
[RequireComponent(typeof(CharacterMotor))]
[AddComponentMenu("Character/FPS Input Controller")]


public class FPSInputController : MonoBehaviour
{
    public CharacterMotor motor;
	public static FPSInputController instance;
	Vector3 directionVector;
	public float initialZ = 0f;
	public float Acceleration, SlowDown;

    // Use this for initialization
    void Awake()
    {
		instance = this;
		motor = GetComponent<CharacterMotor>();
		Acceleration = 0.08f;
		SlowDown = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 XRotation = Vector3.zero;

		// Get the input vector from kayboard or analog stick
        // Vector3 directionVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		directionVector.z = initialZ - (SlowDown * (initialZ)) + (Acceleration*Input.GetAxis ("Vertical"));

		// Disable reverse travel
		if (directionVector.z < 0)
						directionVector.z = 0;

		/*if (directionVector != Vector3.zero)
        {
            // Get the length of the directon vector and then normalize it
            // Dividing by the length is cheaper than normalizing when we already have the length anyway
            float directionLength = directionVector.magnitude;
            directionVector = directionVector / directionLength;

            // Make sure the length is no bigger than 1
            directionLength = Mathf.Min(1.0f, directionLength);

            // Make the input vector more sensitive towards the extremes and less sensitive in the middle
            // This makes it easier to control slow speeds when using analog sticks
            directionLength = directionLength * directionLength;

            // Multiply the normalized direction vector by the modified length
            directionVector = directionVector * directionLength;
        }
		*/

		// Rotate Handle Axially 
		XRotation.y = (((Input.GetAxis("Horizontal") + 1f) * 2f) - 2f);
		transform.Rotate (XRotation);



		// motor.inputMoveDirection =  + directionVector.z;

		// Apply the direction to the CharacterMotor
        motor.inputMoveDirection = transform.rotation * directionVector;
	
		initialZ = directionVector.z;
        //motor.inputJump = Input.GetButton("Jump");
    }
}