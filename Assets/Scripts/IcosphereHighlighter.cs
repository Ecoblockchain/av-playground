using UnityEngine;
using System.Collections;
using VRTK;

/* attach to right controller */
public class IcosphereHighlighter : MonoBehaviour {
	private GameObject lastHitByRay;
	private GameObject nowHitByRay;
	private VRTK_SimplePointer simplePointer;
	private SequenceChanger sequenceChanger;

	void Start(){
		simplePointer = gameObject.GetComponent<VRTK_SimplePointer>();
	}

	void Update(){
		nowHitByRay = simplePointer.pointerTarget.gameObject;

		if (lastHitByRay){
		    if (lastHitByRay != nowHitByRay){ // if the hovered object is different than the last
		    	if (sequenceChanger = nowHitByRay.GetComponent<SequenceChanger>()){
		    		if(sequenceChanger.toggle){
		    			nowHitByRay.GetComponent<Renderer>().sharedMaterial = sequenceChanger.mat4; // highlight bluegreen
		    		}
		    		else {
		    			nowHitByRay.GetComponent<Renderer>().sharedMaterial = sequenceChanger.mat3; // highlight blue
		    		}
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
		   	else{ // still highlighted on same object
				if (sequenceChanger = nowHitByRay.GetComponent<SequenceChanger>()){
		    		if(sequenceChanger.toggle){
						nowHitByRay.GetComponent<Renderer>().sharedMaterial = sequenceChanger.mat4; // highlight bluegreen
		    		}
		    		else{
						nowHitByRay.GetComponent<Renderer>().sharedMaterial = sequenceChanger.mat3; // highlight blue
		    		}
				}		   		
		   	}			
		}
	    lastHitByRay = nowHitByRay;
	}

}