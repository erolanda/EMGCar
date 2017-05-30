using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class ardControl : MonoBehaviour {
    private CarController m_Car;
    public SerialController serialController;

    private void Awake()
    {
        // get the car controller
        m_Car = GetComponent<CarController>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        //serialController.SendSerialMessage("a");
        string message = serialController.ReadSerialMessage();
        Debug.Log(message);

        if (message == null)
            return;
        else
        {
            float value = 0;
            if(float.TryParse(message, out value))
            {
                if (value == 0f)
                    m_Car.Move(0.5f, 0.4f, 0.3f, 0f);
                else if (value == 1f)
                    m_Car.Move(-0.5f, 0.4f, 0.3f, 0f);
            }
        }
    }
}
