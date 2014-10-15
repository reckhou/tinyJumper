using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

	public enum Status {
		left,
		right,
		up,
		down,
		jump,
		idle
	};

	public float speed = 1;
	public int status = (int)Status.idle;
	public float jumpForce = 100;
	public bool OnAir = false;

	private int doubleJumpCnt = 0;
	public int MaxJumpCnt = 2;
	private EdgeCollider2D groundCollider;

	// Use this for initialization
	void Start () {
		groundCollider = GetComponent<EdgeCollider2D>();
	}

	public void Move (bool toRight) {
		status = (int)(toRight ? Status.right : Status.left);
	}

	public void Idle () {
		status = (int)Status.idle;
	}

	public void TouchGround() {
		doubleJumpCnt = 0;
		OnAir = false;
	}

	public void Jump() {
		if (OnAir && doubleJumpCnt >= MaxJumpCnt) {
			return;
		}
		status = (int)Status.idle;
		OnAir = true;
		rigidbody2D.velocity = new Vector2(0, 0);
		rigidbody2D.angularVelocity = 0;
		rigidbody2D.AddForce(Vector2.up * jumpForce);
		doubleJumpCnt++;
	}
	
	// Update is called once per frame
	void Update () {
		if (status == (int)Status.left) {
			transform.Translate(Vector3.left * Time.deltaTime * speed);
		} else if (status == (int)Status.right) {
			transform.Translate(Vector3.right * Time.deltaTime * speed);
		}
	}	
}
