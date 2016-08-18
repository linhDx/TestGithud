using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {
	void Update(){
		gameObject.transform.position += new Vector3 (-0.1f, 0f, 0f);
	}
	// Use this for initialization
	void OnCollisionEnter(Collision coll){
		Debug.Log ("aaaaaa");
		if (coll.gameObject.name=="Collision") {
			Destroy (gameObject);
		}
	}
}
