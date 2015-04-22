using UnityEngine;
using System.Collections;

public class ReturnMain : MonoBehaviour {
	float width = Screen.width ;
	float height = Screen.height ;
	
	void OnGUI() {
		//GUI.Box(new Rect(410, 284, 100, 100), "Welcome!");
		if (GUI.Button(new Rect(width * (float)0.76, height * (float)0.91, width * (float)0.2, height * (float)0.05), "返回作业选择")) 
		{
			Application.LoadLevel("Main");
		}

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
