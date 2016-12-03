using UnityEngine;
using System.Collections;

public class RotateSusan : MonoBehaviour {

	public AnimationCurve OpenOutCurve;
	public float SpeedMultiplier;
	public int numPedestals;
	public float rotAmount;

	void Start () {
	}
	
	// eventually replace this with swipe events
	void Update () {

       GameObject hihat = GameObject.Find("HiHat");
       GameObject kick = GameObject.Find("Kick");
       GameObject snare = GameObject.Find("Snare");
       GameObject crash = GameObject.Find("Crash");
       GameObject melody = GameObject.Find("Melody");

        if (Input.GetKey("right")){
            hihat.transform.Rotate(Vector3.down * Time.deltaTime * rotAmount);
            kick.transform.Rotate(Vector3.down * Time.deltaTime * rotAmount);
            snare.transform.Rotate(Vector3.down * Time.deltaTime * rotAmount);
            crash.transform.Rotate(Vector3.down * Time.deltaTime * rotAmount);
            melody.transform.Rotate(Vector3.down * Time.deltaTime * rotAmount);
            print("Moving Right");
        }
        
        if (Input.GetKey("left")){
	        hihat.transform.Rotate(Vector3.up * Time.deltaTime * rotAmount);
	        kick.transform.Rotate(Vector3.up * Time.deltaTime * rotAmount);
	        snare.transform.Rotate(Vector3.up * Time.deltaTime * rotAmount);
	        crash.transform.Rotate(Vector3.up * Time.deltaTime * rotAmount);
	        melody.transform.Rotate(Vector3.up * Time.deltaTime * rotAmount);
	        print("Moving Left");
        }
	}
/*
	public void OpenOut(Vector3 vector){
		StartCoroutine(_openOut(vector));
	}

	IEnumerator _openOut(Vector3 vector){
		float curveTime = 0f;
		float curveAmount = OpenOutCurve.Evaluate(curveTime);
		//float rotAmount = 360.0f/numPedestals;
		while (curveAmount < 1.0f){
			curveTime += Time.deltaTime * SpeedMultiplier;
			curveAmount = OpenOutCurve.Evaluate(curveTime);
			transform.Rotate(vector * Time.deltaTime * curveAmount * rotAmount);
			yield return null;
		}

	}
*/
}
