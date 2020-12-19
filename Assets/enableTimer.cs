using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableTimer : MonoBehaviour
{
    private GameObject timerController;
    void Start()
    {
        if (timerController == null)
        timerController = GameObject.FindWithTag("TimerController");
        timerController.SetActive(true);
    }

}
