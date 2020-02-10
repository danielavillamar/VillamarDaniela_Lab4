using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour

{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    //bool active;
    //Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenuUI.SetActive(false);
        //canvas = GetComponent<Canvas>();
        //canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //active = !active;
            //canvas.enabled = active;
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pausa();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pausa()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
      
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
