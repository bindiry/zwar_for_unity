using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour
{

		public GameObject PlayerPrefab;
		public GameObject MonsterPrefab;

		private float addMonsterNextTime;
		private float addMonsterTime;

		// Use this for initialization
		void Start ()
		{
			addMonsterNextTime = 0.0f;
			addMonsterTime = 1f;
			Instantiate (PlayerPrefab, new Vector3 (30, Screen.height / 2, 0), Quaternion.identity);
		}
	
		// Update is called once per frame
		void Update ()
		{
			// 每一秒钟添加一个怪物
			if (Time.time > addMonsterNextTime) {
				addMonsterNextTime = Time.time + addMonsterTime;
				AddMonster ();
			}
		}

		// 添加怪物
		void AddMonster ()
		{
			float halfMonsterWidth = MonsterPrefab.renderer.bounds.size.x / 2;
			float halfMonsterHeight = MonsterPrefab.renderer.bounds.size.y / 2;
			float bornX = Screen.width + halfMonsterWidth;
			float bornY = Random.Range (halfMonsterHeight, Screen.height - halfMonsterHeight);
			Instantiate (MonsterPrefab, new Vector3 (bornX, bornY, 0), Quaternion.identity);
		}
}
