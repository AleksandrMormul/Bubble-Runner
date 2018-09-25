using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void Play()
	{if(Input.touchCount == 1)
		SceneManager.LoadScene("GameScene");

	}
	
	public void Qiut()
	{if(Input.touchCount == 1)
			//SceneManager.LoadScene("GameScene");
		Application.Quit();
	}
}
