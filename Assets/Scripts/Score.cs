using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public int score;

	void Start () {
		score = 0;
	}
	
	void Update () {
		guiText.text = score.ToString();
	}
}
