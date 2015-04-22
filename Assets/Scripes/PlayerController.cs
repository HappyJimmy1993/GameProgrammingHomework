using UnityEngine;
using System.Collections;



//[RequireComponent(typeof(AudioSource))]
public class PlayerController : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	public UnityEngine.UI.Text Score;
    public UnityEngine.UI.Text Win;
	public UnityEngine.UI.Text Timer;
	public UnityEngine.AudioSource aud;
	public UnityEngine.UI.Button Pause_button;
	private int count;
    public GameObject tp1;
    public GameObject tp2;
    enum stats { Menu, Pause, Playing ,Ending};
	private float remain_time;
	int stat = (int)stats.Menu;

    float left = Screen.width / 2 - 50;
    float top = Screen.height / 3;

	void OnGUI() {
        switch (stat) {
            case (int)stats.Menu:
                //GUI.Box(new Rect(410, 284, 100, 100), "Welcome!");
                GUI.Box(new Rect(left - 10, top - 30, 120, 120), "Welcome!");
                if (GUI.Button(new Rect(left, top , 100, 30), "New Game")) 
                {
                    InitNewGame();
                    stat = (int)stats.Playing ;
                }
                if (GUI.Button(new Rect(left, top + 50, 100, 30), "Exit")) 
                {
                    Application.Quit();
                }
                break;
            case (int)stats.Pause:
                GUI.Box(new Rect(left - 10, top - 50, 120, 150), "Pause!");
                if (GUI.Button(new Rect(left, top - 20, 100, 30), "Resume"))
                {
                    speed = 800;
                    rb.WakeUp();
                    stat = (int)stats.Playing;
                }
                if (GUI.Button(new Rect(left,top + 20,100,30), "New Game"))
                {
                    InitNewGame();
                    stat = (int)stats.Playing ;
                }
                if (GUI.Button(new Rect(left, top + 60, 100, 30), "Exit"))
                {
                    Application.Quit();
                }
                break;
            case (int)stats.Playing:
                if (GUI.Button(new Rect(Screen.width * (float)0.78 - 120, 10, 100, 30), "Pause"))
                {
                    speed = 0;
                    rb.Sleep();
                    stat = (int)stats.Pause;
                   // Win.text = "Pause!";
                }
                break;
            case (int)stats.Ending:
                GUI.Box(new Rect(left - 10, top - 40, 120, 130), "Time's up!\nFinal Score:" + count.ToString());
                if (GUI.Button(new Rect(left,top + 10,100,30), "New Game"))
                {
                    InitNewGame();
                    stat = (int)stats.Playing ;
                }
                if (GUI.Button(new Rect(left, top + 50, 100, 30), "Exit"))
                {
                    Application.Quit();
                }
                break;
        }

	}
	
	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
        Win.text = "";
		count = 0;
		remain_time = 20;
		SetCountText ();

	}

	// Update is called once per frame
	void Update () 
	{
        if (stat == (int)stats.Playing)
        {
            remain_time -= Time.deltaTime; 
        }
		
		float remain_t = (float)(int)(remain_time*10)/10;
		Timer.text = "Time:  " + remain_t.ToString();
		if (remain_time <= 0) {
			//Win.text = "Time's up!";
            stat = (int)stats.Ending;
			rb.Sleep();
            speed = 0;
		}
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		if (remain_time < 0) remain_time = 0;
		rb.AddForce (movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);
		if (other.gameObject.tag == "PickUp") {
			//other.gameObject.SetActive (false);

			other.gameObject.GetComponent<Transform>().position	
				= new Vector3(Random.value*16 - 8,(float)0.5,Random.value*16 - 8);
			aud.Play ();
			count = count + 1;
			SetCountText();

		}
	}

	void SetCountText(){
		Score.text = "Score: " + count.ToString ();
	}

    void InitNewGame()
    {
        rb.position = new Vector3(0, (float)0.5, 0);
        Win.text = "";
        count = 0;
        remain_time = 20;
        speed = 800;
        SetCountText();
        tp1.GetComponent<Transform>().position
                = new Vector3(Random.value * 16 - 8, (float)0.5, Random.value * 16 - 8);
        tp2.GetComponent<Transform>().position
                = new Vector3(Random.value * 16 - 8, (float)0.5, Random.value * 16 - 8);
        rb.WakeUp();
        
    }
}
