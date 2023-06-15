using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour {

	public string nextLevel;

	private void OnTriggerEnter(Collider col)
	{
		if (col.CompareTag ("Player")) {
			SceneManager.LoadScene (nextLevel);
		}
	
	}
}
	