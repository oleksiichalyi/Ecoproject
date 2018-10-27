using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameScript : MonoBehaviour {

	public QuestionList[] questions;
	public Text qText;

	public void OnClickPlay()
	{
		qText.text = questions [Random.Range (0, questions.Length)].question;

	}

}
[System.Serializable]
public class QuestionList
{
	public string question;
	public string[] answers = new string[3];
}
