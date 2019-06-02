using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class ChangeScene : MonoBehaviour
{
	public string goToScene;

	public void NextScene()
	{
		Application.LoadLevel (goToScene);
	}
}
