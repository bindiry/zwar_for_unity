using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

	public GameObject PlayerPrefab;
	//public GameObject MonsterPrefab;

	// Use this for initialization
	void Start () {
		GameObject player = Instantiate(PlayerPrefab, new Vector3(-Screen.width / 2 + 30, 0, 0), Quaternion.identity) as GameObject;

		print(player.transform.position.x);
		print(player.transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
