using UnityEngine;
using System.Collections;

public class ResultCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Score score = GameObject.Find("Score").GetComponent("Score") as Score;
		score.score = PlayerPrefs.GetInt("score");
		PlayerPrefs.DeleteKey("score");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		float buttonX = (Screen.width - 150) / 2;
		float buttonY = (Screen.height - 60) / 2;

		if (GUI.Button (new Rect (buttonX, buttonY, 150, 60), "Replay"))
		{
			Application.LoadLevel("MainScene");
		}
	}
}
