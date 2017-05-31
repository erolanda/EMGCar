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

    // Creación del timer
	// Se obtienen los minutos y segundos y se les aplica un formato 00:00
	// Se muestra en pantall el tiempo mediante la variable text_timer
    void Update () {
        if(start_timer){
            time += Time.deltaTime;
			int minutes = Mathf.FloorToInt(time / 60F);
			int seconds = Mathf.FloorToInt(time - minutes * 60);
			string niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);
			text_timer.text = niceTime;
        }
    }

	// Iniciar o detener el timer
	// Inicializar el timer cuando el coche colisione con la marca de Inicio
	// Detener el timer cuando el coche colisione con la marca de fin
	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Inicio")) {
			start_timer = true;
		}else if (other.CompareTag ("Fin")) {
			start_timer = false;
			finJuego ();
		}
	}

	// Mostrar mensaje de fin de juego.
	void finJuego(){
		string msj = "Felicidades has completado la pista en : " + text_timer.text;
		text_fin.text = msj;
	}
}
