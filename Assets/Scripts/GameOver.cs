using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
	public void Retry()
	{//if(Input.touchCount == 1)
		
			Time.timeScale = 1f;
	
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void Menu()
	{//if(Input.touchCount == 1)
		SceneManager.LoadScene("MainMenu");
	}
}
