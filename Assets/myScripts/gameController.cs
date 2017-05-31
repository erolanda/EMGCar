using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Recargar la escena cuando el usuario presione la tecla R
	void Update(){
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
