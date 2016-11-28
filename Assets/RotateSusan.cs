using UnityEngine;
using System.Collections;

public class RotateSusan : MonoBehaviour {

	public AnimationCurve OpenOutCurve;
	public float SpeedMultiplier;
	public int numPedestals;

	void Start () {
	}
	
	// eventually replace this with swipe events
	void Update () {
        if (Input.GetKey("right")){
            OpenOut(Vector3.up);
        }
        
        if (Input.GetKey("left")){
            OpenOut(Vector3.down);
        }
	}

	public void OpenOut(Vector3 vector){
		StartCoroutine(_openOut(vector));
	}

	IEnumerator _openOut(Vector3 vector){
		float curveTime = 0f;
		float curveAmount = OpenOutCurve.Evaluate(curveTime);
		//float rotAmount = 360.0f/numPedestals;
		float rotAmount = 30.0f;

		while (curveAmount < 1.0f){
			curveTime += Time.deltaTime * SpeedMultiplier;
			curveAmount = OpenOutCurve.Evaluate(curveTime);
			transform.Rotate(vector * Time.deltaTime * curveAmount * rotAmount);
			yield return null;
		}

	}
}
