using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public GameObject ProjectilePrefab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			AddProjectile();
		}
	}

	void AddProjectile()
	{
		// get Projectile start position
		Vector3 startPos = new Vector3(this.transform.position.x, this.transform.position.y);
		// get mouse position
		Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
		// get distance
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
