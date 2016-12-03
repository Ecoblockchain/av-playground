using UnityEngine;
using System.Collections;
using VRTK;

public class IcosphereHightlighter : MonoBehaviour {
	private GameObject controller;

	void Start(){
		
	}

	void Update(){
	    controller = GameObject.Find("Controller (right)");
	    VRTK_SimplePointer simplePointer = controller.GetComponent<VRTK_SimplePointer>();
	    if (gameObject == simplePointer.pointerTarget){
	        gameObject.GetComponent<Renderer>().sharedMaterial = gameObject.GetComponent<SequenceChanger>().mat3;
	    } else{
	        gameObject.GetComponent<Renderer>().sharedMaterial = gameObject.GetComponent<SequenceChanger>().mat3;
	    }	
	}
}