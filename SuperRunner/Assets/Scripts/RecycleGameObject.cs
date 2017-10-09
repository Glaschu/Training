using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleGameObject : MonoBehaviour {

	// Use this for initialization
	public void Restart () {
		gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	public void Shutdown () {
		gameObject.SetActive (false);
	}
}
