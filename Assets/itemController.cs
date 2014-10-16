using UnityEngine;
using System.Collections;

public class itemController : MonoBehaviour {

	private triggerController trigger;

	void Start() {
		trigger = transform.FindChild("Trigger").GetComponent<triggerController>();
	}

	public void OnTrigger() {
		print("Item Triggered!");

		SpriteRenderer rend = GetComponent<SpriteRenderer>();
		Color color = rend.color;
		color.r = 0;
		rend.color = color;
	}
}
