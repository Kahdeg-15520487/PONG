using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pong : MonoBehaviour {
	public float speed = 100;
	private Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		Vector2 v2;
		int i = Random.Range (0, 2);
		if (i==0)
			v2 = new Vector2 (-1.5f + Random.Range(-0.5f,0.5f), Random.Range(-0.5f,0.5f));
		else v2 = new Vector2 (1.5f + Random.Range(-0.5f,0.5f), Random.Range(-0.5f,0.5f));
		//rb.isKinematic = false;
		rb.AddForce (v2 * speed);
	}
	void Update(){
		Vector2 v2 = new Vector2 (0.0f, Random.Range (-2.0f, 3.0f));
		rb.AddForce (v2);
        Debug.DrawRay(rb.position, rb.velocity);
	}
}
