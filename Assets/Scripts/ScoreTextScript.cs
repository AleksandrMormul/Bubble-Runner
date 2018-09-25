using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{

	public Text goldsCountText;
 
	public static int goldCount;
	 
	private void Start()
	{
		goldCount = 0;	
		goldsCountText = GetComponent<Text>();	
	}

	private void Update()
	{
		goldsCountText.text = goldCount.ToString();
	 
	}
	
}
