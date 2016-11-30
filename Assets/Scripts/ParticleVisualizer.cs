using UnityEngine;
using System.Collections;

public class ParticleVisualizer : MonoBehaviour {

	public int sampleSize = 1024;
	public float[] samples;
	public ParticleSystem particleSystem;
	private float sum;
	private float rmsValue;
	private float refValue = 0.1f;
	private float dbValue;

	void Start() {
		samples = new float[sampleSize];
		particleSystem = gameObject.GetComponent<ParticleSystem>();
	}

	void Update(){
		AudioListener.GetOutputData(samples, 0);
		for(int i = 0; i< sampleSize ; i++){
			sum += samples[i]*samples[i];
		}
	    rmsValue = Mathf.Sqrt(sum/sampleSize); // rms = square root of average
	    dbValue = 20*Mathf.Log10(rmsValue/refValue); // calculate dB
	    Debug.Log(dbValue);
	    if (dbValue < -160) dbValue = -160; // clamp it to -160dB min
	    var emission = particleSystem.emission;
	    if (dbValue > 40.0f) {
	    	//emission.rate = 100.0f;
	    	//particleSystem.startSpeed = 10.0f;
	    	particleSystem.Play();
	    } else{
	    	particleSystem.Stop();
	    }
	}

}
