using UnityEngine;
using System.Collections;

public class StartSceneController : MonoBehaviour {
	public float FadeTime = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			Application.LoadLevel("main");
		}
	}
}
