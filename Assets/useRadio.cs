using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR;

public class useRadio : MonoBehaviour
{
    //use the Event menu in the Inspector of this object to attach a function which can be triggered by pressing the trigger
    public SteamVR_Action_Boolean radioClick;
    public SteamVR_Input_Sources inputSource;
    public UnityEvent onTriggerDown;

    void Start()
    {
        radioClick = SteamVR_Actions._default.GrabPinch;
    }

    void Update()
    {
        //this allows you to trigger anything you attach to the Event list in the inspector
        if (radioClick.GetStateDown(SteamVR_Input_Sources.Any))
        {
            onTriggerDown.Invoke();
        }
    }
    //public void testUnityEvent()
    //{
    //    Debug.Log("Trigger Pressed");
    //}
}
