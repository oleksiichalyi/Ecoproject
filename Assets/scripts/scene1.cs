using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class scene1 : MonoBehaviour {

	public void OnClickStart()
	{ 
		SceneManager.LoadScene (1);
	}
}
