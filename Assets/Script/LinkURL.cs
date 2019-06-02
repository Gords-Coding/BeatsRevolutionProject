using UnityEngine;
using System.Collections;

public class LinkURL : MonoBehaviour
{
	public string URL;

	public void OpenURL()
	{
		Application.OpenURL(URL);
	}

}