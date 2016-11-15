using UnityEngine;
using System.Collections;

public class ControllerManager : MonoBehaviour {
    private SteamVR_TrackedObject trackedObject;
    private SteamVR_Controller.Device device;
    private Valve.VR.EVRButtonId trigger = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    private Valve.VR.EVRButtonId touchpad = Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad;

    void Start(){
        trackedObject = GetComponent<SteamVR_TrackedObject>();
    }

    void Update(){
        device = SteamVR_Controller.Input((int)trackedObject.index);
        if (device.GetAxis().x != 0 || device.GetAxis().y != 0){
            Debug.Log(device.GetAxis().x + " " + device.GetAxis().y);
        }
        if (device.GetPressDown(trigger)){
            Debug.Log("Trigger Press");
            device.TriggerHapticPulse(700);
        }
        if (device.GetPressDown(touchpad)){
            Debug.Log("Touchpad Press");
        }
    }

}