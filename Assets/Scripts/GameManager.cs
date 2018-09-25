using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	public static bool gameIsOver;
	public static bool gameIsWin;
    public static bool gameIsPause;

	public GameObject gameOverUI;
	public GameObject winGameUI;
	public GameObject goldsCountUI;
	public GameObject progressToWinGameUI;


	private void Start()
	{
		gameIsOver = false;
		gameIsWin = false;
        gameIsPause = false;
       
	}

	// Update is called once per frame
	void Update ()
	{
		if (gameIsOver)
			return;

       
        if (PlayerControl.dead  )
		{
			
			EndGame();
                 
		} 
			
 

		if (PlayerControl.isWin )
		{
			
			WinGame();           
		}

      

        if (gameIsOver||gameIsWin||PauseMenu.isPauseGame)

        {

            Time.timeScale = 0f;

        }
        else
        {
            Time.timeScale = 1f;
        }
 
			 
	}
	 
	private void EndGame()
	{
		gameIsOver = true;
		 
		gameOverUI.SetActive(true);
	    goldsCountUI.SetActive(false);
        progressToWinGameUI.SetActive(false);	
	}

	private void WinGame()
	{
		gameIsWin = true;

		winGameUI.SetActive(true);
		goldsCountUI.SetActive(false);
		progressToWinGameUI.SetActive(false);		
	}

}
