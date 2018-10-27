using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour {
	public void OnClickStart()
	{ 
		SceneManager.LoadScene (0);
	}
}
