using UnityEngine;
using System.Collections;
using VRTK;

public class IcosphereHighlighter : MonoBehaviour {
	public GameObject device;
	private VRTK_SimplePointer simplePointer;

	void Start(){
	    simplePointer = device.GetComponent<VRTK_SimplePointer>();
	}

	void Update(){
		Debug.Log("Hello: ", simplePointer.pointerTarget);
	   /* if (gameObject == simplePointer.pointerTarget){
	        gameObject.GetComponent<Renderer>().sharedMaterial = gameObject.GetComponent<SequenceChanger>().mat3;
	    }*/
	}
}