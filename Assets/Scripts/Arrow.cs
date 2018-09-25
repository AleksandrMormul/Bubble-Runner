using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Arrow : MonoBehaviour
{
	private float speed;

	public enum Direction
	{
		right, left, up, down
	}

	public Direction arrowDirection;

	private void Start()
	{
		speed = Random.Range(1f, 1.5f);
	}

	private void Update()
	{
		if (arrowDirection == Direction.left)
		{
			gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
		}if (arrowDirection == Direction.down)
		{
			gameObject.transform.Translate(Vector3.down * speed * Time.deltaTime);
		}if (arrowDirection == Direction.up)
		{
			gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
		}if (arrowDirection == Direction.right)
		{
			gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
	
		
	}

	 

	private void OnTriggerEnter2D(Collider2D other)
	{

		
             		
		
		if (other.gameObject.name == SpawnManager.Instance.leftCollider.gameObject.name)
		{
		
			
			SpawnManager.Instance.SpawnLeftTransforms();
			Destroy(gameObject);
			
			
		}
		if (other.gameObject.name == SpawnManager.Instance.rightCollider.gameObject.name)
		{
			//Debug.Log("2");
	SpawnManager.Instance.SpawnRightTransforms();
			Destroy(gameObject);
			
		}
		
		if (other.gameObject.name == SpawnManager.Instance.downCollider.gameObject.name)
		{
			//Debug.Log("3");
			SpawnManager.Instance.SpawnDownTransforms();
			Destroy(gameObject);
			
		}
		
		if (other.gameObject.name == SpawnManager.Instance.upCollider.gameObject.name)
		{
			//Debug.Log("4");
			SpawnManager.Instance.SpawnUpTransforms();
			Destroy(gameObject);
			
		}

	}
}
