using UnityEngine;
using System.Collections;

public class FightScript : MonoBehaviour {
	public bool tem;
	public Animator temp;
	// Use this for initialization
	void Start () {
		temp = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Z))
		{
			temp.SetBool("fight", true);
		}
		if (Input.GetKeyUp(KeyCode.Z))
		{
			temp.SetBool("fight", false);
		}
	}
}
