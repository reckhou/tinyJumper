using UnityEngine;
using System.Collections;

public class triggerController : MonoBehaviour {

	public enum Type {
		normal,
		narrator
	};

	public int triggerType = (int)Type.normal;
	public bool reusable = false;

	private itemController parent;

	// Use this for initialization
	void Start () {
		parent = transform.parent.GetComponent<itemController>();
	}

	void OnTriggerEnter2D(Collider2D collider) {
		print("Trigger!");

		if (!reusable) {
			GetComponent<BoxCollider2D>().enabled = false;
			this.enabled = false;
		}

		parent.OnTrigger();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
