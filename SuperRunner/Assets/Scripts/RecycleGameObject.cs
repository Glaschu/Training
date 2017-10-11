using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRecycle{
	void Restart ();
	void Shutdown ();
}
public class RecycleGameObject : MonoBehaviour {

	private List<IRecycle> recycleComponents;

	void Awake(){
		var components = GetComponents<MonoBehaviour> ();
		recycleComponents = new List<IRecycle> ();
		foreach (var component in components) {
			if (component is IRecycle) {
				recycleComponents.Add (component as IRecycle);

			}
		}
	
	}
	// Use this for initialization
	public void Restart () {
		gameObject.SetActive (true);

		foreach (var components in recycleComponents) {
			components.Restart ();
		}
	}
	
	// Update is called once per frame
	public void Shutdown () {
		gameObject.SetActive (false);
		foreach (var components in recycleComponents) {
			components.Shutdown ();
		}
	}
}
