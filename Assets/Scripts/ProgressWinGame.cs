using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressWinGame : MonoBehaviour
{

	public static ProgressWinGame Instance;

	private void Awake()
	{

		Instance = this;
	}
	public Text howGoldToWinGameText;
	
	public int howGoldToWin;

	private void Start ()
	{
		
		howGoldToWinGameText = GetComponent<Text>();	
	}
	

	private void Update ()
	{		
		howGoldToWinGameText.text = howGoldToWin.ToString();
	}

	
	
}
