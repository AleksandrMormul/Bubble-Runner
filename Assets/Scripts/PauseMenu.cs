using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;

    public static PauseMenu Instance;

    public static bool isPauseGame;


    private void Awake()
    {

        Instance = this;
    }


    private void Start()
    {
        isPauseGame = false;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            Toggle();
              
        }
    }


    public void Toggle()
    {
        pauseUI.SetActive(!pauseUI.activeSelf);

        if (pauseUI.activeSelf)
        {
            //Time.timeScale = 0f;
            isPauseGame = true;
        }
        else
        {
            //Time.timeScale = 1f;
            isPauseGame = false;
        }
    }


    public void Continue()
    {
        pauseUI.SetActive(false);
       
        
    }



	public void Retry()
	{
		
		//if(Input.touchCount == 1)
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void Menu()
	{//if(Input.touchCount == 1)
	SceneManager.LoadScene("MainMenu");
	}
}
