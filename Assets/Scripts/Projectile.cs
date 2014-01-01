using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	private Vector3 _targetPos;

	private float moveSpeed;
	// Use this for initialization
	void Start () {
		moveSpeed = 500;
	}
	
	// Update is called once per frame
	void Update () {
		if (_targetPos.x != 0)
		{
			transform.position = Vector3.MoveTowards(transform.position, _targetPos, moveSpeed * Time.deltaTime);
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
			// add score
			Score score = GameObject.Find("Score").GetComponent("Score") as Score;
			score.score += 1;
			Destroy(collider.gameObject);
			Destroy(this.gameObject);
		}

	}

	public Vector3 targetPos 
	{
		set { _targetPos = value; }
	}
}
