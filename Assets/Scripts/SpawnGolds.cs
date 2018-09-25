using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGolds : MonoBehaviour {

	public Transform[] goldPointTransforms;
	public GameObject golds;
	public Collider2D goldCollider;
	
	public static SpawnGolds Instance;

	private void Awake()
	{

		Instance = this;
	}
	void Start ()
	{
		goldSpawn();
	}
	
	

	public void goldSpawn()
	{
		GameObject arrowLeft = Instantiate(golds,	goldPointTransforms[Random.Range(0, goldPointTransforms.Length)].position,
			goldPointTransforms[Random.Range(0, goldPointTransforms.Length)].rotation);
	}
}
