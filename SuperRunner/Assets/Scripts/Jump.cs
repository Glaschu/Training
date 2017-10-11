using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	public float jumpSpeed =240f;
	public float fowardSpeed =20f;
	private InputState inputState;
	private Rigidbody2D body2d;
	// Use this for initialization
	void Start () {
		body2d = GetComponent<Rigidbody2D> ();
		inputState = GetComponent<InputState> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (inputState.standing) {
			if (inputState.actionButton) {
				body2d.velocity = new Vector2 (transform.position.x<0?fowardSpeed:0, jumpSpeed);
			}
		}
	}
}
