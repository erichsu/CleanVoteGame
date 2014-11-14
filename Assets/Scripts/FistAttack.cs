using UnityEngine;
using System.Collections;

public class FistAttack : MonoBehaviour {

	private GameObject bound;
	private BoundDetector boundDetector;
	private Animator anim;

	// Use this for initialization
	void Start () {
		bound = GameObject.Find ("Bound");
		boundDetector = bound.GetComponent<BoundDetector> ();
		anim = GameObject.Find ("Fist").GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1") && boundDetector.punchPoint == 100f)
		{
			// ... set the animator Shoot trigger parameter and play the audioclip.
			
			boundDetector.punchPoint = 0f;
			anim.SetBool("FistReady", false);
		}
	}
}
