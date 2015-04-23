using UnityEngine;
using System.Collections;

public class HW4_Cube : MonoBehaviour {
	public GameObject tp1;
	public GameObject tp2;
	private float start_time;

	// Use this for initialization
	void Start () {
		start_time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		start_time += Time.deltaTime;
		if (start_time > 8)
			start_time = 0.0f;
		float nowpos = start_time * 4 - 16;
		if (nowpos < 0) 
			nowpos = - nowpos;

		nowpos = nowpos - 8.0f;
		tp1.GetComponent<Transform> ().position
			= new Vector3 (nowpos, (float)10, (float)-4);
		tp2.GetComponent<Transform> ().Rotate(new Vector3 (0f, 0f, Time.deltaTime * 100));
	}
}
