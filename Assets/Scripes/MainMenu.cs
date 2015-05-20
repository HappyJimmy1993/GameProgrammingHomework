using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	float width = Screen.width ;
	float height = Screen.height ;
	
	void OnGUI() {
			//GUI.Box(new Rect(410, 284, 100, 100), "Welcome!");
		GUI.Box(new Rect(width * (float)0.28, height * (float)0.01, width * (float)0.44, height * (float)0.1), "请选择需要查看的作业——5120379068王勇杰");
		if (GUI.Button(new Rect(width * (float)0.76, height * (float)0.01, width * (float)0.2, height * (float)0.1), "退出")) 
		{
			Application.Quit();
		}
		if (GUI.Button(new Rect(width * (float)0.28, height * (float)0.12, width * (float)0.44, height * (float)0.1), "Homework1_基本流程")) 
		{
			Application.LoadLevel("HW1");
		}
		if (GUI.Button(new Rect(width * (float)0.04, height * (float)0.23, width * (float)0.2, height * (float)0.1), "Homework2_模型10%简化")) 
		{
			Application.LoadLevel("HW2_10%");
		}
		if (GUI.Button(new Rect(width * (float)0.28, height * (float)0.23, width * (float)0.2, height * (float)0.1), "Homework2_模型20%简化")) 
		{
			Application.LoadLevel("HW2_20%");
		}
		if (GUI.Button(new Rect(width * (float)0.52, height * (float)0.23, width * (float)0.2, height * (float)0.1), "Homework2_模型50%简化")) 
		{
			Application.LoadLevel("HW2_50%");
		}
		if (GUI.Button(new Rect(width * (float)0.76, height * (float)0.23, width * (float)0.2, height * (float)0.1), "Homework2_模型无简化")) 
		{
			Application.LoadLevel("HW2_100%");
		}
		if (GUI.Button(new Rect(width * (float)0.28, height * (float)0.34, width * (float)0.44, height * (float)0.1), "Homework3_动画和控制")) 
		{
			Application.LoadLevel("HW3");
		}
		if (GUI.Button(new Rect(width * (float)0.28, height * (float)0.45, width * (float)0.44, height * (float)0.1), "Homework4_粒子系统与光影特效")) 
		{
			Application.LoadLevel("HW4");
		}
		if (GUI.Button(new Rect(width * (float)0.28, height * (float)0.56, width * (float)0.44, height * (float)0.1), "Homework5_自定义特效Shader")) 
		{
			Application.LoadLevel("HW5");
		}
	}
		

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
	
	}
}
