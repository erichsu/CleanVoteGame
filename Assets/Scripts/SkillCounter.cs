using UnityEngine;
using System.Collections;

public class SkillCounter : MonoBehaviour {

	public float skillPoint = 0f;
	public float skillAmount = 0.1f;

	private Vector3 skillBarScale;

	// Use this for initialization
	void Awake () {
		skillBarScale = GameObject.Find ("SkillBar").GetComponent<SpriteRenderer> ().transform.localScale;
		UpdateSkillBar ();
		InvokeRepeating ("AddSkillPoint", 1f, 0.1f);
	}

	void AddSkillPoint () {

		if (skillPoint >= 100f) {
			skillPoint = 100f;
			return;
		}

		skillPoint += skillAmount;
		UpdateSkillBar ();

	}

	void UpdateSkillBar () {
		SpriteRenderer skillBar = GameObject.Find("SkillBar").GetComponent<SpriteRenderer>();
		skillBar.transform.localScale = new Vector3(skillBarScale.x * skillPoint * 0.01f, 1, 1);
	}
}
