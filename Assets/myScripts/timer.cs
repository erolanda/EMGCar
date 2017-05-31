using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    private string text_time;
    public float start_timer;
    private float time;
	public Text text_timer;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update () {
        if(start_timer > 0){
            time += Time.deltaTime;
			int minutes = Mathf.FloorToInt(time / 60F);
			int seconds = Mathf.FloorToInt(time - minutes * 60);
			string niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);
			text_timer.text = niceTime;
        }
    }
}
