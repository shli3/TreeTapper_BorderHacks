using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

	public void triggerMenuBehavoir(int i){
		switch(i){
		default:
		case(0):
			SceneManager.LoadScene("Play");
			break;
		case(1):
			Application.Quit();
			#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
			#endif
			break;
		}
	}
}