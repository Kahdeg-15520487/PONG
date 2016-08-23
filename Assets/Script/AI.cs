using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
    public float speed = 10;
    public float intelligent = 0;
    public Rigidbody2D rb;
    public GameController gc;
    private GameObject ball;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<Player2>().enabled = false;
    }

    void Update()
    {
        if (ball == null)
            ball = findBall();
        float d = ball.transform.position.y - transform.position.y;
        //if (ball.transform.position.x>0){
            if(d > 0.8){
                rb.AddForce(Vector2.up * speed);
            }
            else if (d < -0.8)
            {
                rb.AddForce(Vector2.down * speed);
            }
        //}
        if (gc.ai == false)
            GetComponent<Player2>().enabled = true;
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log(coll.gameObject);
        if (coll.gameObject.tag == "pong")
            coll.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * -3);
    }
    GameObject findBall()
    {
        GameObject result;
        result = GameObject.FindGameObjectWithTag("pong");
        return result;
    }
}
