using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public GameObject ProjectilePrefab;

	void Start () {
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			AddProjectile();
		}
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.name == "Monster(Clone)")
		{
			MainCamera mainCamera = GameObject.Find("MainCamera").GetComponent("MainCamera") as MainCamera;
			mainCamera.resetTime();

			Score score = GameObject.Find("Score").GetComponent("Score") as Score;
			PlayerPrefs.SetInt("score", score.score);
			Application.LoadLevel("ResultScene");
		}
		
	}

	void AddProjectile()
	{
		Vector3 startPos = new Vector3(this.transform.position.x, this.transform.position.y);
		Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
		Vector3 distance = new Vector3(mousePos.x - startPos.x, mousePos.y - startPos.y);

		if (distance.x <= 0) return;

		GameObject projectile = Instantiate(ProjectilePrefab, startPos, Quaternion.identity) as GameObject;

		float realX = Screen.width + projectile.renderer.bounds.size.x / 2;
		float ratio = distance.y / distance.x;
		float realY = (realX * ratio) + projectile.transform.position.y;
		Vector3 realDest = new Vector3(realX, realY);

		Projectile p = projectile.GetComponent("Projectile") as Projectile;
		p.targetPos = realDest;
	}
}
