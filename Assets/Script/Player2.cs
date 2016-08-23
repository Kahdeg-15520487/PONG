using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {
	public float speed;
	public Rigidbody2D rb;
    public GameController gc;
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
        GetComponent<AI>().enabled = false;
	}
	
	void Update()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			//Debug.Log("up2");
			rb.AddForce(Vector2.up * speed);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			//Debug.Log("down2");
			rb.AddForce(Vector2.down * speed);
		}
        if (gc.ai == true)
            GetComponent<AI>().enabled = true;
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log(coll.gameObject);
        if (coll.gameObject.tag == "pong")
            coll.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * -3);
    }
}
