using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour {

    public void Retry()
    { 
Time.timeScale = 1f; 



       // if(Input.touchCount == 1)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
      //  if(Input.touchCount == 1)
        SceneManager.LoadScene("MainMenu");
    }


    public void NextLevel()
    {
       // if(Input.touchCount == 1)
        Debug.Log("Next Level.......");
    }

}
