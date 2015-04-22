using UnityEngine;
using System.Collections;

public class change_bianxingjingang : MonoBehaviour {
	public Animator temp;
	// Use this for initialization
	void Start () {
		temp = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.E))
		{
			temp.SetBool("run", true);
		}

	}

}
