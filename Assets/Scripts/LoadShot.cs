using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadShot : MonoBehaviour {

	public string sceneName;

	public void loadfunction()
	{
		SceneManager.LoadScene (sceneName);

	}
    
}
