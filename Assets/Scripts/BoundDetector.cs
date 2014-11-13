using UnityEngine;
using System.Collections;

public class BoundDetector : MonoBehaviour {

	public float punchPoint = 0f;
	public float pointAmount = 10f;

	private SpriteRenderer attackBar;
	private Vector3 attackScale;

	void Awake () {
		attackBar = GameObject.Find("AttackBar").GetComponent<SpriteRenderer>();
		attackScale = attackBar.transform.localScale;
		UpdateAttackBar ();
	}

	void OnCollisionEnter2D (Collision2D col) {
		// If the colliding gameobject is an Enemy...
		if(col.gameObject.tag == "Enemy") {
			Destroy(col.gameObject);
			AddPunchPoint();
		}
	}

	void AddPunchPoint ()
	{
		if (punchPoint >= 100) {
			punchPoint = 100f;
			return;
		}
		// Reduce the player's health by 10.
		punchPoint += pointAmount;
		
		// Update what the health bar looks like.
		UpdateAttackBar();
		
		// Play a random clip of the player getting hurt.
		//		int i = Random.Range (0, ouchClips.Length);
		//		AudioSource.PlayClipAtPoint(ouchClips[i], transform.position);
	}

	void UpdateAttackBar () {
		attackBar.transform.localScale = new Vector3(attackScale.x * punchPoint * 0.01f, 1, 1);
	}
}
