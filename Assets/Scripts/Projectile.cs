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

		if (this.transform.position.x >= Screen.width + this.renderer.bounds.size.x / 2)
		{
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.name == "Monster(Clone)")
		{
			Destroy(collider.gameObject);
			Destroy(this.gameObject);
		}

	}
}
