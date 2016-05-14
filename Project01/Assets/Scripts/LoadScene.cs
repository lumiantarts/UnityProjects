using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public void ButtonLoadScene(int index)
	{
		Application.LoadLevel(index);
	}
	
	public void ButtonLoadScene(string levelName)
	{
		Application.LoadLevel(levelName);
	}
}