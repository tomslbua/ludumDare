using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public Canvas pauseMenu;
    public GameObject UIMenu;

    public static bool GameIsPaused = false;

    private void Update()
    {

       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else {
                Pause();

            }
        }
    }

    public void Resume()
    {
        pauseMenu.enabled = false;
        UIMenu.enabled = true;
        UIMenu.setActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("resume");
    }

    void Pause()
    {
        
        pauseMenu.enabled = true;
        UIMenu.enabled = false;
        
        UIMenu.setActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Debug.Log("paused");
    }

    public void QuitToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);      
    }
}
