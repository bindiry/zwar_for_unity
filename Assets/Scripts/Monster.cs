using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour
{
	private float moveSpeed;

	void Start ()
	{
		MainCamera mainCamera = GameObject.Find("MainCamera").GetComponent("MainCamera") as MainCamera;
		moveSpeed = Random.Range (80, 200) + mainCamera.gameTime * 5;
	}

	void Update ()
	{
		transform.Translate (-moveSpeed * Time.deltaTime, 0, 0);
		
		if (transform.position.x <= -this.renderer.bounds.size.x / 2)
		{
			MainCamera mainCamera = GameObject.Find("MainCamera").GetComponent("MainCamera") as MainCamera;
			mainCamera.resetTime();

			Score score = GameObject.Find("Score").GetComponent("Score") as Score;
			PlayerPrefs.SetInt("score", score.score);
			Application.LoadLevel("ResultScene");
			Destroy(this.gameObject);
		}
	}
}
