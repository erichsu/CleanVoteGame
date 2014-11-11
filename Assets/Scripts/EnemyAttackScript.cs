using UnityEngine;
using System.Collections;

public class EnemyAttackScript : MonoBehaviour {

	public float minTimeBetweenAttack;
	public float maxTimeBetweenAttack;
	public Rigidbody2D blackBall;

	// Use this for initialization
	void Start () {
		StartCoroutine ("BlackBallAttack");
	}
	
	void FixedUpdate () {

	}

	IEnumerator BlackBallAttack () {

		// Create a random wait time before the prop is instantiated.
		float waitTime = Random.Range(minTimeBetweenAttack, maxTimeBetweenAttack);
		
		// Wait for the designated period.
		yield return new WaitForSeconds(waitTime);
		
		// If the prop is facing left, it should start on the right hand side, otherwise it should start on the left.
		float posX = Random.Range(-1.6f, 2.4f);;
		
		// Create a random y coordinate for the prop.
		float posY = 1.18f;
		
		// Set the position the prop should spawn at.
		Vector3 pos = new Vector3(posX, posY, transform.position.z);
		
		// Instantiate the prop at the desired position.
		Rigidbody2D propInstance = Instantiate(blackBall, pos, Quaternion.identity) as Rigidbody2D;

		float speed = 1f;

		// Set the prop's velocity to this speed in the x axis.
		propInstance.velocity = new Vector2(speed, 0);
		
		// Restart the coroutine to spawn another prop.
		StartCoroutine(BlackBallAttack());
		
		// While the prop exists...
		while(propInstance != null)
		{
			if (propInstance.position.y < -20f)
				Destroy(propInstance.gameObject);
			
			// Return to this point after the next update.
			yield return null;
		}
	}
}
