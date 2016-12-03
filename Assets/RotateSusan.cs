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

}
