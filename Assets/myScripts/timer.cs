using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    private string text_time;
	private bool start_timer = false;
    private float time;
	public Text text_timer;
	public Text text_fin;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update () {
        if(start_timer){
            time += Time.deltaTime;
			int minutes = Mathf.FloorToInt(time / 60F);
			int seconds = Mathf.FloorToInt(time - minutes * 60);
			string niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);
			text_timer.text = niceTime;
        }
    }

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Inicio")) {
			start_timer = true;
		}else if (other.CompareTag ("Fin")) {
			start_timer = false;
			finJuego ();
		}
	}

	void finJuego(){
		string msj = "Felicidades has completado la pista en : " + text_timer.text;
		text_fin.text = msj;
	}
}
