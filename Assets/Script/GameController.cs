using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
	public Transform prefab;
	public Transform prefab2;
    public GameObject ball;
	private Text Score1;
	private Text Score2;
    private Text aiText;
	private int s1=0;
	private int s2=0;
    private bool spawned = false;
    public bool ai = false;
	// Use this for initialization
	void Start () {
		Score1 = GameObject.Find("score1").GetComponent<UnityEngine.UI.Text>();
		Score2 = GameObject.Find("score2").GetComponent<UnityEngine.UI.Text>();
        aiText = GameObject.Find("ai").GetComponent<UnityEngine.UI.Text>();
	}
	
	// Update is called once per frame
	public void S1 () {
		s1++;
		Score1.text = s1.ToString ();
        spawned = false;
	}
	public void S2 () {
		s2++;
		Score2.text = s2.ToString ();
        spawned = false;
	}
	public void Reset(){
		GameObject[] po = GameObject.FindGameObjectsWithTag("pong");
		foreach (GameObject poc in po)
			Destroy(poc.gameObject);
		po = GameObject.FindGameObjectsWithTag("mbar");
		foreach (GameObject poc in po)
			Destroy(poc.gameObject);
		s1 = 0;
		Score1.text = s1.ToString ();
		s2 = 0;
		Score2.text = s2.ToString ();
        spawned = false;
        ai = false;
	}

	public void Update(){
		if ((Input.GetKey (KeyCode.H) == true)&&(spawned==false)) {
            spawned = true;
			Instantiate (prefab, new Vector3 (0, 0, 0), Quaternion.identity);
		}
        ball = findBall();
        if (ball==null && spawned==false && ai == true)
        {
            spawned = true;
			Instantiate (prefab, new Vector3 (0, 0, 0), Quaternion.identity);
        }
		if (Input.GetKey (KeyCode.Escape) == true)
			Application.Quit ();
		if (Input.GetKeyUp (KeyCode.Delete) == true)
			Reset ();
        if (Input.GetKeyDown(KeyCode.P) == true)
            if (ai == true)
            {
                ai = false;
                aiText.text = "off";
            }
            else
            {
                ai = true;
                aiText.text = "on";
            }
	}
    GameObject findBall()
    {
        GameObject result;
        result = GameObject.FindGameObjectWithTag("pong");
        return result;
    }
}
