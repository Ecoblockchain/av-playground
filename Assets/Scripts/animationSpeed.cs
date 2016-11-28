using UnityEngine;
using System.Collections;

public class animationSpeed : MonoBehaviour {
	public Animation anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation>();
		foreach (AnimationState state in anim) {
			state.speed = 2F;
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
