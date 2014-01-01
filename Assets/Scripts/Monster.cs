using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour
{
	private float moveSpeed;
	// Use this for initialization
	void Start ()
	{
		moveSpeed = Random.Range (50, 100) + Time.time * 2;
	}

	// Update is called once per frame
	void Update ()
	{
		transform.Translate (-moveSpeed * Time.deltaTime, 0, 0);
		
		if (transform.position.x <= -this.renderer.bounds.size.x / 2)
		{
			// change scene
			Score score = GameObject.Find("Score").GetComponent("Score") as Score;
			PlayerPrefs.SetInt("score", score.score);
			Application.LoadLevel("ResultScene");
			Destroy(this.gameObject);
		}
	}
}
