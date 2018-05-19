using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIController : MonoBehaviour {

    // Use this for initialization
    bool paused = false;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        if (paused == false)
        {
            Time.timeScale = 0.0f;
            paused = true;
        }
    }

    public void StartGame()
    {
        if (paused == true)
        {
            Time.timeScale = 1.0f;
            paused = false;
        }
    }
}
