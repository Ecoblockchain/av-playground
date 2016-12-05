using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	private Sequencer hihat;
	private Sequencer kick;
	private Sequencer snare;
	private Sequencer crash;
	private Sequencer melodyA;
	private Sequencer melodyC;
	private Sequencer melodyD;
	private Sequencer melodyE;
	private Sequencer melodyG;


	void Start(){
		hihat = GameObject.Find("HiHat").GetComponent<Sequencer>();
		kick = GameObject.Find("Kick").GetComponent<Sequencer>();
		snare = GameObject.Find("Snare").GetComponent<Sequencer>();
		crash = GameObject.Find("Crash").GetComponent<Sequencer>();
		melodyA = GameObject.Find("A").GetComponent<Sequencer>();
		melodyC = GameObject.Find("C").GetComponent<Sequencer>();
		melodyD = GameObject.Find("D").GetComponent<Sequencer>();
		melodyE = GameObject.Find("E").GetComponent<Sequencer>();
		melodyG = GameObject.Find("G").GetComponent<Sequencer>();
	}

	void Update(){}

	public void ResetSequencers(){
		for (int i = 0; i < 8; i++){
			hihat.sequence[i] = false;
			kick.sequence[i] = false;
			snare.sequence[i] = false;
			crash.sequence[i] = false;
			melodyA.sequence[i] = false;
			melodyC.sequence[i] = false;
			melodyD.sequence[i] = false;
			melodyE.sequence[i] = false;
			melodyG.sequence[i] = false;
		}
	}
}