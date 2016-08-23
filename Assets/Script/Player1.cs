using UnityEngine;
using System.Collections;


public class Player1 : MonoBehaviour {
	//public float yMin, yMax;
	public float speed;
	public Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.W))
		{
			//Debug.Log("up1");
			rb.AddForce(Vector2.up * speed);
		}
		if (Input.GetKey(KeyCode.S))
		{
			//Debug.Log("down1");
			rb.AddForce(Vector2.down * speed);
		}
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log(coll.gameObject);
        if (coll.gameObject.tag == "pong")
            coll.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * -3);

    }
}
