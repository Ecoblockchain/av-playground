using UnityEngine;
using System.Collections;
using VRTK;

public class IcosphereActivator : MonoBehaviour {
	void Start(){

	}

	void Update(){

	}

	public void activateIcosphere(){
		Debug.Log("test");
		VRTK_SimplePointer simplePointer = gameObject.GetComponent<VRTK_SimplePointer>();
		Debug.Log(simplePointer.pointerTarget);	
		SequenceChanger sequenceChanger;
		if (sequenceChanger = simplePointer.pointerTarget.GetComponent<SequenceChanger>()){
			sequenceChanger.toggle = !sequenceChanger.toggle;
		}
		
	}
}