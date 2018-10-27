using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoogleApi : MonoBehaviour {

	public RawImage img;

	string url;


	LocationInfo li;


	public enum mapType {roadmap,satellite,hybrid,terrain}
	public mapType mapSelected;


	IEnumerator Map()
	{
		url = "http://tile.openweathermap.org/map/temp_new/10/50.4199/30.5447.png?appid=f27fa7d147523e07d4ddd0f1b7b9dde1";
		WWW www = new WWW (url);
		yield return www;
		img.texture = www.texture;
		img.SetNativeSize ();

	}
	// Use this for initialization
	void Start () {
		img = gameObject.GetComponent<RawImage> ();
		StartCoroutine (Map());
	}
		
}