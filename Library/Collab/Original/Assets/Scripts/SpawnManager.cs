using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public static SpawnManager Instance;

	private void Awake()
	{

		Instance = this;
	}

	public Collider2D leftCollider;
	public Collider2D rightCollider;
	public Collider2D upCollider;
	public Collider2D downCollider;
	
	public GameObject _arrow;
	
	
	
	public Transform[] leftTransforms;
	public Transform[] rightTransforms;
	public Transform[] downTransforms;
	public Transform[] upTransforms;

	private void Start()
	{
		SpawnLeftTransforms();
		SpawnRightTransforms();
		SpawnDownTransforms();
		SpawnUpTransforms();
		 
	
	}

	public void SpawnLeftTransforms()
	{
		GameObject arrowLeft = Instantiate(_arrow,	leftTransforms[Random.Range(0, leftTransforms.Length)].position,
			leftTransforms[Random.Range(0, leftTransforms.Length)].rotation);
		arrowLeft.GetComponent<Arrow>().arrowDirection = Arrow.Direction.right;
		
	}
	public void SpawnRightTransforms()
	{
		GameObject arrowRight = Instantiate(_arrow,	rightTransforms[Random.Range(0, rightTransforms.Length)].position,
			rightTransforms[Random.Range(0, rightTransforms.Length)].rotation);
		arrowRight.GetComponent<Arrow>().arrowDirection = Arrow.Direction.left;
	}
	
	public void SpawnDownTransforms()
	{
		GameObject	arrowDown = Instantiate(_arrow,	downTransforms[Random.Range(0, downTransforms.Length)].position,
			downTransforms[Random.Range(0, downTransforms.Length)].rotation);
		arrowDown.GetComponent<Arrow>().arrowDirection = Arrow.Direction.up;

	}
	public void SpawnUpTransforms()
	{
		GameObject arrowUp = Instantiate(_arrow,	upTransforms[Random.Range(0, upTransforms.Length)].position,
			upTransforms[Random.Range(0, upTransforms.Length)].rotation);
		arrowUp.GetComponent<Arrow>().arrowDirection = Arrow.Direction.down;
	}

}