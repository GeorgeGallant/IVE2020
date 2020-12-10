using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR;

public class choiceSelection : MonoBehaviour
{
    public SteamVR_Action_Boolean trigger;
    public string nextScene;
    private void OnTriggerEnter(Collider other)
    {
        if (trigger.GetStateDown(SteamVR_Input_Sources.RightHand))
        {
            //*play matching scene or clip*
            SceneManager.LoadScene(nextScene);
            Debug.Log("Button Selected");
        }
 
         
    }
}