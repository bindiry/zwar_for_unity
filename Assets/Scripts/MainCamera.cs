using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour
{

	public GameObject PlayerPrefab;
	public GameObject MonsterPrefab;
	

	private float _addMonsterNextTime;
	private float _addMonsterTime;
	private float _gameTime;

	void Start ()
	{
		_gameTime = 0.0f;
		_addMonsterNextTime = 0.0f;
		_addMonsterTime = 1f;
		Instantiate (PlayerPrefab, new Vector3 (30, Screen.height / 2, 0), Quaternion.identity);
	}

	void Update ()
	{
		if (Time.time > _addMonsterNextTime) {
			_addMonsterNextTime = Time.time + _addMonsterTime;
			AddMonster ();
		}

		_gameTime += Time.deltaTime;
	}

	void AddMonster ()
	{
		float halfMonsterWidth = MonsterPrefab.renderer.bounds.size.x / 2;
		float halfMonsterHeight = MonsterPrefab.renderer.bounds.size.y / 2;
		float bornX = Screen.width + halfMonsterWidth;
		float bornY = Random.Range (halfMonsterHeight, Screen.height - halfMonsterHeight);
		Instantiate (MonsterPrefab, new Vector3 (bornX, bornY, 0), Quaternion.identity);
	}

	public void resetTime()
	{
		_gameTime = 0.0f;
	}

	public float gameTime
	{
		get { return _gameTime; }
	}
}
