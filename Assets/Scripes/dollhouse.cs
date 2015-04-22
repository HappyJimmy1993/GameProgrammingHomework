using UnityEngine;
using System.Collections;

public class dollhouse : MonoBehaviour {
	int stat = 0;
	private Vector3 tem = new Vector3(0.002f,0.002f,0.002f);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.F))
		{
			stat = stat + 1;
		}
		if (Input.GetKeyUp(KeyCode.F))
		{
			stat = stat - 1;
		}
		if (Input.GetKeyDown(KeyCode.G))
		{
			stat = stat - 1;
		}
		if (Input.GetKeyUp(KeyCode.G))
		{
			stat = stat + 1;
		}
		transform.localScale = transform.localScale + tem * stat;
		Vector3 aa = transform.localScale;
		if (aa.x < 0.1)
			transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
		if (aa.x > 1)
			transform.localScale = new Vector3 (1f, 1f, 1f);
	}
}
