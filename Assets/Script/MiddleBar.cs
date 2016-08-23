using UnityEngine;
using System.Collections;

public class MiddleBar : MonoBehaviour {
	public float speed=100;
	public Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (Vector2.up*speed);
		rb.velocity = Vector2.up * speed;
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = Vector2.up * speed;
	}
}
