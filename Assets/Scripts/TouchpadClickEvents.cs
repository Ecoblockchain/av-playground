using UnityEngine;
using System.Collections;
using Valve.VR;
[RequireComponent(typeof(SteamVR_TrackedObject))]

public class TouchpadClickEvents : MonoBehaviour {
    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;
    public float rotAmount;

    void Awake(){
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }


    // Use this for initialization
    void Start(){

    }

    void FixedUpdate(){
        device = SteamVR_Controller.Input((int)trackedObj.index);
    }

    // Update is called once per frame
    void Update(){
        if (device.GetPress(SteamVR_Controller.ButtonMask.Touchpad)){
            Vector2 touchpad = (device.GetAxis(Valve.VR.EVRButtonId.k_EButton_Axis0));
            print("Pressing Touchpad");

           GameObject hihat = GameObject.Find("HiHat");
           GameObject kick = GameObject.Find("Kick");
           GameObject snare = GameObject.Find("Snare");
           GameObject crash = GameObject.Find("Crash");
           GameObject melody = GameObject.Find("Melody");

            if (touchpad.y > 0.7f){
                Debug.Log("moving up");
            }
            else if (touchpad.y < -0.7f){
                Debug.Log("moving down");
            }
            if (touchpad.x > 0.7f){ // right
                hihat.transform.RotateAround(hihat.GetComponent<Collider>().bounds.center, Vector3.down, rotAmount * Time.deltaTime);
                kick.transform.RotateAround(kick.GetComponent<Collider>().bounds.center, Vector3.down, rotAmount * Time.deltaTime);
                snare.transform.RotateAround(snare.GetComponent<Collider>().bounds.center, Vector3.down, rotAmount * Time.deltaTime);
                crash.transform.RotateAround(crash.GetComponent<Collider>().bounds.center, Vector3.down, rotAmount * Time.deltaTime);
                melody.transform.RotateAround(melody.GetComponent<Collider>().bounds.center, Vector3.down, rotAmount * Time.deltaTime);
            }
            else if (touchpad.x < -0.7f){ // left
                hihat.transform.RotateAround(hihat.GetComponent<Collider>().bounds.center, Vector3.up, rotAmount * Time.deltaTime);
                kick.transform.RotateAround(kick.GetComponent<Collider>().bounds.center, Vector3.up, rotAmount * Time.deltaTime);
                snare.transform.RotateAround(snare.GetComponent<Collider>().bounds.center, Vector3.up, rotAmount * Time.deltaTime);
                crash.transform.RotateAround(crash.GetComponent<Collider>().bounds.center, Vector3.up, rotAmount * Time.deltaTime);
                melody.transform.RotateAround(melody.GetComponent<Collider>().bounds.center, Vector3.up, rotAmount * Time.deltaTime);
            }
        }
    }

}