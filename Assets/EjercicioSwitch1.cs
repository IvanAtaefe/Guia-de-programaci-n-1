using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioSwitch1 : MonoBehaviour
{
    // Start is called before the first frame update
    public string nombre;
    void Start()
    {
        switch (nombre)
        {

            case "Mercurio":
                Debug.Log("Primer Planeta");
                break;
            case "Venus":
                Debug.Log("Segundo Planeta");
                break;
            case "Tierra":
                Debug.Log("Tercer Planeta");
                break;
            case "Marte":
                Debug.Log("Cuarto Planeta");
                break;
            case "Jupiter":
                Debug.Log("Quinto Planeta");
                break;
            case "Saturno":
                Debug.Log("Sexto Planeta");
                break;
            case "Neptuno":
                Debug.Log("Septimo Planeta");
                break;
            case "Urano":
                Debug.Log("Octavo Planeta");
                break;
            default:
                Debug.Log("No es un planeta");
                break;
        }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
