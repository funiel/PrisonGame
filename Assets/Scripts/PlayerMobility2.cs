﻿using UnityEngine;
using System.Collections;

public class PlayerMobility : MonoBehaviour {

	public float speed;

	void FixedUpdate()
	{
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

		transform.rotation = rot;
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		GetComponent<Rigidbody2D>().angularVelocity = 0;


	}

	void Update() {
		if(Input.GetKey(KeyCode.W)) {
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed);
		}

		if(Input.GetKey(KeyCode.A)) {
			GetComponent<Rigidbody2D>().AddForce(-Vector2.right * speed);
		}

		if(Input.GetKey(KeyCode.S)) {
			GetComponent<Rigidbody2D>().AddForce(-Vector2.up * speed);
		}

		if(Input.GetKey(KeyCode.D)) {
			GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed);
		}
	}

}
