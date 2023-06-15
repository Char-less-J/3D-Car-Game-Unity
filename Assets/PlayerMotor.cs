﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

	private CharacterController controller;
	
	private float verticalVelocity;
	private float gravity = 20.0f;
	private float jumpForce = 10.0f;

	private void Start()
		{
		controller = GetComponent<CharacterController> ();
		}

		private void Update()
		{
			if(controller.isGrounded)
			{
				verticalVelocity = -gravity * Time.deltaTime;
				if(Input.GetKeyDown(KeyCode.Space))
				{
					verticalVelocity = jumpForce;
				}
			}

			else
			{
				verticalVelocity -= gravity * Time.deltaTime;
			}

			Vector3 moveVector = Vector3.zero;
			moveVector.x = Input.GetAxis ("Horizontal") * 20.0f;
			moveVector.y = verticalVelocity;
			moveVector.z = Input.GetAxis("Vertical") * 20.0f;
			controller.Move (moveVector * Time.deltaTime);
		}
}