using UnityEngine;
using System.Collections;

public class GameControllerPlatform : MonoBehaviour {
	public CharController mainChar;
	public MusicController musicController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")) {
			print("Jump!");
			mainChar.Jump();
			musicController.Switch();
			return;
		}
		if (Input.GetKey("left")) {
			mainChar.Move(false);
		} else if (Input.GetKey("right")) {
			mainChar.Move(true);
		} else {
			mainChar.Idle();
		}
	}
}
