﻿using UnityEngine;
using System.Collections;

public class ControllerManager : MonoBehaviour {
    private SteamVR_TrackedObject trackedObject;
    private SteamVR_Controller.Device device;
    void Start(){
        trackedObject = GetComponent<SteamVR_TrackedObject>();
    }
    void Update(){
        device = SteamVR_Controller.Input((int)trackedObject.index);
        if (device.GetAxis().x != 0 || device.GetAxis().y != 0){
            Debug.Log(device.GetAxis().x + " " + device.GetAxis().y);
        }
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger)){
            Debug.Log("Trigger Press");
            device.TriggerHapticPulse(700);
        }
    }
}