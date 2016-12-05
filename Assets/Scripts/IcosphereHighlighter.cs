using UnityEngine;
using System.Collections;
using VRTK;

/* attach to right controller */
public class IcosphereHighlighter : MonoBehaviour {
	private GameObject lastHitByRay;
	private GameObject nowHitByRay;
	private VRTK_SimplePointer simplePointer;

	void Start(){
		simplePointer = gameObject.GetComponent<VRTK_SimplePointer>();
	}

	void Update(){
		nowHitByRay = simplePointer.pointerTarget.gameObject;
	    if (lastHitByRay && lastHitByRay != nowHitByRay){
	    	SequenceChanger sequenceChanger;
	    	if (sequenceChanger = nowHitByRay.GetComponent<SequenceChanger>()){
	    		nowHitByRay.GetComponent<Renderer>().sharedMaterial = sequenceChanger.mat3; // highlight blue
	    	}
	    	else if (sequenceChanger = lastHitByRay.GetComponent<SequenceChanger>()){
	    		if(sequenceChanger.toggle){
	    			lastHitByRay.GetComponent<Renderer>().sharedMaterial = sequenceChanger.mat1; // green glow
	    		}
	    		else{
	    			lastHitByRay.GetComponent<Renderer>().sharedMaterial = sequenceChanger.mat2; // default
	    		}
	    	}
	    }
	    lastHitByRay = nowHitByRay;
	}

}