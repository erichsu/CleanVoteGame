using UnityEngine;
using System.Collections;

public class KerPControllerScript : MonoBehaviour {

	float maxSpeed = 10f;

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");
		rigidbody2D.velocity = new Vector2 (maxSpeed * move, rigidbody2D.velocity.y);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
