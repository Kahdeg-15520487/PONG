using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Boundary2 : MonoBehaviour {
	GameObject gcobj;
	GameController gc;
	void Start(){
		gcobj = GameObject.Find ("GameController");
		gc = gcobj.GetComponent<GameController> ();
	}
	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "pong") {
			Debug.Log ("collision name = " + other.gameObject.name);
			Destroy(other.gameObject);
			gc.S1();
		}
	}
}
