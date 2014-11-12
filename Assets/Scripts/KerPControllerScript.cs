using UnityEngine;
using System.Collections;

public class KerPControllerScript : MonoBehaviour {

	private float maxSpeed = 10f;
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");
		float speed = maxSpeed * move;
		rigidbody2D.velocity = new Vector2 (speed, rigidbody2D.velocity.y);

		anim.SetFloat ("speed", speed);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
