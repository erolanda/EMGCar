using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class ardControl : MonoBehaviour {
    private CarController m_Car;
    public SerialController serialController;

	//Referencia al controlador del coche.
    private void Awake()
    {
        m_Car = GetComponent<CarController>();
    }

	//Realiza una lectura del puerto serial, de acuerdo al valor recibido
	//se elige un movimiento para el coche.
    private void FixedUpdate()
    {
        string message = serialController.ReadSerialMessage();
        //Debug.Log(message);

		if (message == null) {
			return;
		}
        else
        {
            float value = 0;
            if(float.TryParse(message, out value))
            {
				if (value == 0f)
					m_Car.Move (0.5f, 0.20f, 0.20f, 0f);
				else if (value == 1f)
					m_Car.Move (0f, 0.50f, 0.50f, 0f);
				else if (value == 2f)
					m_Car.Move (-0.5f, 0.20f, 0.20f, 0f);
            }
        }
    }
}
