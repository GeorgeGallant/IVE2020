using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR;

public class choiceSelection : MonoBehaviour
{
    //public SteamVR_Action_Boolean trigger;
    //private SteamVR_Input_Sources inputSource;
    public string nextScene;
    //bool buttonDown = false;

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "hand")
        {
            //*play matching scene or clip*
            SceneManager.LoadScene(nextScene);
            Debug.Log("Button Selected");
        }

    }
}