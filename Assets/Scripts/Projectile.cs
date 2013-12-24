using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public Vector3 targetPos;

	private float moveSpeed;
	// Use this for initialization
	void Start () {
		moveSpeed = 500;
	}
	
	// Update is called once per frame
	void Update () {
		if (targetPos != null)
		{
			transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
		}
	}
}
