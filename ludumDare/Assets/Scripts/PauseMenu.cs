using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public Canvas pauseMenu;

    public static bool GameIsPaused = false;

    private void Update()
    {

       
        if (Input.GetKeyDown(KeyCode.A))
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
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("resume");
    }

    void Pause()
    {
        pauseMenu.enabled = true;
        Time.timeScale = 0f;
        GameIsPaused = true;
        Debug.Log("paused");
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
