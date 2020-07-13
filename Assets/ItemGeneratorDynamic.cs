using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGeneratorDynamic : MonoBehaviour 
{

	public GameObject carPrefab;
	public GameObject coinPrefab;
	public GameObject conePrefab;
	private GameObject unitychan;
	private int goalPos = 120;
	private float posRange = 3.4f;
	private float presentPos;
	private float pastPos;
	private float spawnPos;

	// Use this for initialization
	void Start () 
	{
		//スタート地点を最初の計測地として記録。
		this.unitychan = GameObject.Find("unitychan");
		this.pastPos = this.unitychan.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//計測地と現在地の距離が15以上の時、且つ生成ポイントがゴールの位置を超えていない時、アイテムを生成する。
		this.presentPos = this.unitychan.transform.position.z;
		this.spawnPos = this.unitychan.transform.position.z + 50; //生成箇所は50メートル先。
		if ((this.presentPos - this.pastPos <= -15 || 15 <= this.presentPos - this.pastPos) && this.spawnPos < this.goalPos)
		{
			ItemGenerate();
			this.pastPos = this.presentPos;
		}
	}

	private void ItemGenerate()
	{
		int num = Random.Range (1,11);
		if (num <= 2)
		{
			for (float j = -1; j<=1; j += 0.4f)
			{
				GameObject cone = Instantiate (conePrefab) as GameObject;
				cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, this.spawnPos);
			} //for End
		} //if End
		else
		{	
			for (int j = -1; j<=1; j++)
			{
				int item = Random.Range (1,11);
				int offsetZ = Random.Range(-5,6);
				if (1 <= item && item <= 6)
				{
					GameObject coin = Instantiate (coinPrefab) as GameObject;
					coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, this.spawnPos + offsetZ);
				}
				else if (7 <= item && item <= 9)
				{
					GameObject car = Instantiate (carPrefab) as GameObject;
					car.transform.position = new Vector3 (posRange * j, car.transform.position.y, this.spawnPos + offsetZ);
				}
			} //for End
					
		} //else End

	} //ItemGenerate End
}