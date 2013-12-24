using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour
{

		public GameObject PlayerPrefab;
		public GameObject MonsterPrefab;
		private ArrayList monsterList;
		private float addMonsterNextTime;
		private float addMonsterTime;

		// Use this for initialization
		void Start ()
		{
				monsterList = new ArrayList ();
				addMonsterNextTime = 0.0f;
				addMonsterTime = 1f;
				GameObject player = Instantiate (PlayerPrefab, new Vector3 (30, Screen.height / 2, 0), Quaternion.identity) as GameObject;

//		print(player.transform.position.x);
//		print(player.transform.position.y);
				print (MonsterPrefab.renderer.bounds.size.y);
		}
	
		// Update is called once per frame
		void Update ()
		{
			// 每一秒钟添加一个怪物
			if (Time.time > addMonsterNextTime) {
					addMonsterNextTime = Time.time + addMonsterTime;
					AddMonster ();
			}

		// 遍历所有飞镖
			
			// 遍历所有怪物，满足条件的就移除
//			foreach (GameObject monster in monsterList)
//			{
//				if (monster.transform.position.x < -MonsterPrefab.renderer.bounds.size.x / 2)
//				{
//					monsterList.Remove(monster);
//					Destroy(monster);
//				}
//			}
				
		}

		// 添加怪物
		void AddMonster ()
		{
				float halfMonsterWidth = MonsterPrefab.renderer.bounds.size.x / 2;
				float bornX = Screen.width + halfMonsterWidth;
				float halfMonsterHeight = MonsterPrefab.renderer.bounds.size.y / 2;
				float bornY = Random.Range (halfMonsterHeight, Screen.height - halfMonsterHeight);
				GameObject monster = Instantiate (MonsterPrefab, new Vector3 (bornX, bornY, 0), Quaternion.identity) as GameObject;
				monsterList.Add (monster);
		}
}
