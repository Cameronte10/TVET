using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   
    public bool gameScene;
    public GameObject canvas;
    public float timer;

    void Start()
    {
        //controller = GameObject.FindObjectWithTag("Player").GetComponent<FirstPersonController>();
        canvas = GameObject.Find("Canvas");
        if (gameScene)
        {
            canvas.GetComponent<Canvas>().enabled = false;
        }
    }
    public void PLayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Escape) && gameScene)
        {
            
            if (canvas.GetComponent<Canvas>().enabled == true)
            {
                //controller.enabled = true;
                //Cursor.lockState = CursorLockMode.Locked;
                //Cursor.visible = false
                Time.timeScale = 1;
                canvas.GetComponent<Canvas>().enabled = false;
            }
            else
            {
                Time.timeScale = 0;
                canvas.GetComponent<Canvas>().enabled = true;
            }
        }
    }

}
