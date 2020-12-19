using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionTimer : MonoBehaviour
{

    public float timeUntilSelection = 00.0f;
    public GameObject canvasWithButtons;
    private Canvas selection;
    private GameObject Option1;
    private GameObject Option2;
    private GameObject Option3;
    private GameObject Option4;
    private Collider Coll1;
    private Collider Coll2;
    private Collider Coll3;
    private Collider Coll4;


    void Update()
    {

        if (canvasWithButtons == null)
        {
            canvasWithButtons = GameObject.FindWithTag("SelectionCanvas");
            Option1 = GameObject.FindWithTag("Option1");
            Option2 = GameObject.FindWithTag("Option2");
            Option3 = GameObject.FindWithTag("Option3");
            Option4 = GameObject.FindWithTag("Option4");
        }

        if (canvasWithButtons != null)
        {
            timeUntilSelection -= Time.deltaTime;
            selection = canvasWithButtons.GetComponent<Canvas>();
            Coll1 = Option1.GetComponent<BoxCollider>();
            Coll2 = Option1.GetComponent<BoxCollider>();
            Coll3 = Option1.GetComponent<BoxCollider>();
            Coll4 = Option1.GetComponent<BoxCollider>();
        }
        if (timeUntilSelection <= 0.0f)
        {
            timerEnded();
            selection.enabled = true;
            Coll1.enabled = true;
            Coll2.enabled = true;
            Coll3.enabled = true;
            Coll4.enabled = true;
        }
    }

    private void timerEnded()
    {
        
        {
            canvasWithButtons.SetActive(true);
        }

    }
}
