using UnityEngine;
using System.Collections;

public class BlackBallGUIText : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		GUIText[] gts = GetComponentsInChildren<GUIText> ();
		foreach (GUIText gt in gts) {
			gt.transform.position = Camera.main.WorldToViewportPoint(transform.position);
		}
	}
}
