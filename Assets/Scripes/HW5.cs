using UnityEngine;
using System.Collections;

public class HW5 : MonoBehaviour {
	public Camera cam;
	Vector3 pos;
	public GameObject ob;
	// Use this for initialization
	void Start () {
		//Camera.main.SetReplacementShader(Shader.Find("Custom/Test"), "RenderType"); 
		//cam.SetReplacementShader(Shader.Find("Specular"), "RenderType");
		pos = cam.GetComponent<Transform> ().position;
		//cam.GetComponent<Transform> ().position = pos;
	}
	// Update is called once per frame
	void Update () {
/*		if (Input.GetKeyDown(KeyCode.F))
		{
			//Camera.main.SetReplacementShader(Shader.Find("Standard"), "RenderType");
			//cam.SetReplacementShader(Shader.Find("Custom/WaterBlur"), "RenderType");
		}
		if (Input.GetKeyUp(KeyCode.F))
		{
			//Camera.main.ResetReplacementShader();
			//cam.ResetReplacementShader();
		}
*/
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		pos = pos + movement * Time.deltaTime;
		//if (pos.z >= -20f )pos = new Vector3 (-8.8f, 0.6f, -20f);
		//if (pos.z <= -25f) pos = new Vector3 (-9.2f, 0.6f, -25f);

		cam.GetComponent<Transform> ().position = pos;
		ob.GetComponent<Transform> ().position = pos + new Vector3(0f,0f,1f);
		if (movement == new Vector3 (0f, 0f, 0f))
			ob.SetActive(false);
		else
			ob.SetActive(true);
	}
}
