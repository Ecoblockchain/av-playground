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
                hihat.transform.RotateAround(hihat.GetComponent<Collider>().bounds.center, Vector3.down, rotAmount * Time.deltaTime);
                kick.transform.RotateAround(kick.GetComponent<Collider>().bounds.center, Vector3.down, rotAmount * Time.deltaTime);
                snare.transform.RotateAround(snare.GetComponent<Collider>().bounds.center, Vector3.down, rotAmount * Time.deltaTime);
                crash.transform.RotateAround(crash.GetComponent<Collider>().bounds.center, Vector3.down, rotAmount * Time.deltaTime);
                melody.transform.RotateAround(melody.GetComponent<Collider>().bounds.center, Vector3.down, rotAmount * Time.deltaTime);
            print("Moving Right");
        }
        
        if (Input.GetKey("left")){
                hihat.transform.RotateAround(hihat.GetComponent<Collider>().bounds.center, Vector3.up, rotAmount * Time.deltaTime);
                kick.transform.RotateAround(kick.GetComponent<Collider>().bounds.center, Vector3.up, rotAmount * Time.deltaTime);
                snare.transform.RotateAround(snare.GetComponent<Collider>().bounds.center, Vector3.up, rotAmount * Time.deltaTime);
                crash.transform.RotateAround(crash.GetComponent<Collider>().bounds.center, Vector3.up, rotAmount * Time.deltaTime);
                melody.transform.RotateAround(melody.GetComponent<Collider>().bounds.center, Vector3.up, rotAmount * Time.deltaTime);
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
