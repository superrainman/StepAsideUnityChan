using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour {

	//アイテムとカメラとの距離を測定するための変数。
	private float difference;
	private GameObject cam;

	// Use this for initialization
	void Start () 
	{
		//メインカメラの取得。
		this.cam = Camera.main.gameObject;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//カメラとアイテムとの距離が4m以上だった時、Destroy関数でアイテムを破棄する。
		this.difference = this.cam.transform.position.z - this.transform.position.z;
		if (this.difference >= 4.0f)
		{
			Destroy (this.gameObject);
		}
		
	}
}
