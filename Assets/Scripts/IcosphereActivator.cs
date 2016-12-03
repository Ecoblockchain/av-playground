using UnityEngine;
using System.Collections;
using VRTK;

public class IcosphereActivator : MonoBehaviour {
	private GameObject hihat;
	private GameObject kick;
	private GameObject snare;
	private GameObject crash;

	void Start(){

	}

	/* always checking to see if raycast is hitting an orb */
	void Update(){
	}

	/* gets called from controller events when trigger clicked */
	public void activateIcosphere(){
		VRTK_SimplePointer simplePointer = gameObject.GetComponent<VRTK_SimplePointer>();
		SequenceChanger sequenceChanger;
		if (sequenceChanger = simplePointer.pointerTarget.GetComponent<SequenceChanger>()){
			sequenceChanger.toggle = !sequenceChanger.toggle;
		}
		
	}
}