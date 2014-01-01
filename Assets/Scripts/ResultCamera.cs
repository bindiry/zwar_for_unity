using UnityEngine;
using System.Collections;

public class ResultCamera : MonoBehaviour {

	void Start () {
		Score score = GameObject.Find("Score").GetComponent("Score") as Score;
		score.score = PlayerPrefs.GetInt("score");
		PlayerPrefs.DeleteKey("score");
	}
	
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
