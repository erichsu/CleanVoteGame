using UnityEngine;
using System.Collections;

public class LienDControllerScript : MonoBehaviour {

	public float minPosX;				// The lowest possible y coordinate of position.
	public float maxPosX;				// The highest possible y coordinate of position.
	public float minSpeed;					// The lowest possible speed of the prop.
	public float maxSpeed;					// The highest possible speeed of the prop.
	public bool facingLeft;

	private float speed;

	// Use this for initialization
	void Start () {
//		speed = Random.Range (minSpeed, maxSpeed);
	}

	void FixedUpdate () {

//		rigidbody2D.MovePosition (new Vector2 (rigidbody2D.position.x + speed * Time.fixedDeltaTime, rigidbody2D.position.y));
//
//		if (maxPosX - rigidbody2D.position.x < speed * Time.fixedDeltaTime) {
//			facingLeft = false;
//			speed = Random.Range (minSpeed, maxSpeed);
//			speed *= facingLeft ? 1f : -1f;
//
//		} else if (rigidbody2D.position.x - minPosX < speed * Time.fixedDeltaTime) {
//			facingLeft = true;
//			speed = Random.Range (minSpeed, maxSpeed);
//			speed *= facingLeft ? 1f : -1f;
//		}
	}
}
