using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	private GameObject[] hihat;
	private GameObject[] kick;
	private GameObject[] snare;
	private GameObject[] crash;
	private GameObject[] melodyA;
	private GameObject[] melodyC;
	private GameObject[] melodyD;
	private GameObject[] melodyE;
	private GameObject[] melodyG;

	void Start(){
		hihat = GameObject.FindGameObjectsWithTag("hihatParts");
		kick = GameObject.FindGameObjectsWithTag("kickParts");
		snare = GameObject.FindGameObjectsWithTag("snareParts");
		crash = GameObject.FindGameObjectsWithTag("crashParts");
		melodyA = GameObject.FindGameObjectsWithTag("melodyAParts");
		melodyC = GameObject.FindGameObjectsWithTag("melodyCParts");
		melodyD = GameObject.FindGameObjectsWithTag("melodyDParts");
		melodyE = GameObject.FindGameObjectsWithTag("melodyEParts");
		melodyG = GameObject.FindGameObjectsWithTag("melodyGParts");
	}

	void Update(){
		if (Input.GetKey(KeyCode.Space)){
			Debug.Log("Reset");
			ResetSequencers();
		}
	}

	public void ResetSequencers(){
		for (int i = 0; i < 8; i++){
			hihat[i].GetComponent<SequenceChanger>().toggle = false;
			kick[i].GetComponent<SequenceChanger>().toggle = false;
			snare[i].GetComponent<SequenceChanger>().toggle = false;
			crash[i].GetComponent<SequenceChanger>().toggle = false;
			melodyA[i].GetComponent<SequenceChanger>().toggle = false;
			melodyC[i].GetComponent<SequenceChanger>().toggle = false;
			melodyD[i].GetComponent<SequenceChanger>().toggle = false;
			melodyE[i].GetComponent<SequenceChanger>().toggle = false;
			melodyG[i].GetComponent<SequenceChanger>().toggle = false;
		}
	}
}