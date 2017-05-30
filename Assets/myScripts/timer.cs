using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {
    private string text_time;
    public float start_timer;
    private float time;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update () {
        if(start_timer > 0){
            time += Time.deltaTime;
            var minutes = time / 60;
            var seconds = time % 60;
            var fraction = (time * 100) % 100;
            text_time = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);
            Debug.Log(text_time);
        }
    }
}
