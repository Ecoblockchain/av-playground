using UnityEngine;
using System.Collections;

public class audioVisualizer : MonoBehaviour {

	public GameObject prefab;
	public int numberOfObjects = 60;
	public float radius = 5f;
	public GameObject[] cubes;
	public int moveX;
	public int moveY;
	public int moveZ;

	void Start() {
		for (int i = 0; i < numberOfObjects/3; i++){
			Vector3 pos = new Vector3 (16.1f, 0, 1);
			pos = pos + new Vector3 (moveX+(i*0.7f), moveY, moveZ);
			Instantiate (prefab, pos, Quaternion.identity);
		}
		for (int i = 0; i < numberOfObjects/3; i++){
			Vector3 pos = new Vector3 (16.1f, 0, 1);
			pos = pos + new Vector3 (moveX, moveY, moveZ+(i*0.7f));
			Instantiate (prefab, pos, Quaternion.identity);
		}
		for (int i = 0; i < numberOfObjects/3; i++){
			Vector3 pos = new Vector3 (16.1f, 0, 1);
			pos = pos + new Vector3 (moveX+(i*0.7f), moveY, moveZ+13.8f);
			Instantiate (prefab, pos, Quaternion.identity);
		}
		cubes = GameObject.FindGameObjectsWithTag ("cubes");
	}
	void Update(){
		float[] spectrum = AudioListener.GetSpectrumData (1024, 0, FFTWindow.Hamming);
		for(int i = 0; i<numberOfObjects; i++){
			Vector3 previousScale = cubes[i].transform.localScale;
			if (i < 20) {
				previousScale.y = Mathf.Lerp (previousScale.y, spectrum [i] * 20, Time.deltaTime * 30);
			} else if (i > 19 && i < 40) {
				previousScale.y = Mathf.Lerp (previousScale.y, spectrum [i] * 60, Time.deltaTime * 30);
			} else {
				previousScale.y = Mathf.Lerp (previousScale.y, spectrum [i] * 120, Time.deltaTime * 30);
			}
			//previousScale.y = Mathf.Lerp (previousScale.y, spectrum[i] * 10, Time.deltaTime * 30);
			cubes[i].transform.localScale = previousScale;

		}
	}
}
