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
    public GameObject mainCanvas;
    private SceneTracker sceneTracker;
    private void Start()
    {
        // create a reference to the Scene Tracker which is used to track progress
        sceneTracker = GameObject.Find("SceneTracker").GetComponent<SceneTracker>();
        // if the first two buttons have been clicked
        if (sceneTracker.sceneCount >= 2)
        {
            sceneTracker.InvokeSuccess();
        }
    }

    private void Update()
    {
        if (mainCanvas == null)
        {
            mainCanvas = GameObject.FindWithTag("SelectionCanvas");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // only if the index finger press the button
        if (other.gameObject.name.Contains("finger_index"))
        {
            // if the button clicked is the first button and it hasn't been clicked before
            if (this.gameObject.name == "Option #1" && !sceneTracker.button1Clicked)
            {
                // increase sceneCount by 1 and indicate the button has been clicked
                sceneTracker.sceneCount++;
                sceneTracker.button1Clicked = true;
                LoadNewScene();
            }
            // if the button clicked is the second button and it hasn't been clicked before
            else if (this.gameObject.name == "Option #2" && !sceneTracker.button2Clicked)
            {
                // increase sceneCount by 1 and indicate the button has been clicked
                sceneTracker.sceneCount++;
                sceneTracker.button2Clicked = true;
                LoadNewScene();
            }
        }
    }
    private void LoadNewScene()
    {
        //*play matching scene or clip*
        SceneManager.LoadScene(nextScene);
        //Debug.Log("Button Selected");
        mainCanvas.SetActive(false);
        mainCanvas.SetActive(true);
    }
}