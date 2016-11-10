using UnityEngine;
using System.Collections;

public class recenter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKeyDown ("r")) {
			transform.position = new Vector3(0f,1.5f,0f);
		//}
	}
}
