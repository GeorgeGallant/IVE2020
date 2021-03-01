using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneTracker : MonoBehaviour
{
    public int sceneCount = 0;
    public bool button1Clicked = false;
    public bool button2Clicked = false;
    public bool button3Clicked = false;
    private GameObject option2Button;
    private GameObject option3Button;
    private Text option1ButtonText;
    private choiceSelection choiceScript;
    private static SceneTracker instance = null;
    private void Awake()
    {
        // used to only allow one instance of the Scene Tracker in the project
        if (instance == null)
        {
            // if no instance exists yet, set it to don't destroy
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        // delete objects that exist in the scene if one already is
        // persistent
        Destroy(this.gameObject);
    }
    public void InvokeSuccess()
    {
        Invoke("Success", 5f);
    }
    private void Success()
    {

        Scene2Management();
        sceneTrackerReset();
    }
    void Scene2Management()
    {
        // create references to the buttons and script
        option2Button = GameObject.Find("Option #2");
        option3Button = GameObject.Find("Option #3");
        option1ButtonText = GameObject.Find("Option #1").GetComponentInChildren<Text>();
        choiceScript = GameObject.Find("Option #1").GetComponent<choiceSelection>();

        // disable 2nd and 3rd buttons
        option2Button.SetActive(false);
        option3Button.SetActive(false);
        // update the text for the first button and change what scene it goes to
        option1ButtonText.text = "Go Inside";
        choiceScript.nextScene = "2E3A";
    }
    public void sceneTrackerReset()
    {
        // reset the values
        button1Clicked = false;
        button1Clicked = false;
        button3Clicked = false;
        sceneCount = 0;
    }
}
