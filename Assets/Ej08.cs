using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Crear una variable entera que pueda ser modificada desde el Inspector.Suponiendo que
//el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al
//valor de la variable “dia”. Si el día no está en el rango permitido debe emitir por pantalla el
//mensaje de error &quot;El día ingresado no es válido&quot;.
public class Ej08 : MonoBehaviour
{
    // Start is called before the first frame update
    public int dia;
    const int domingo = 1;
    const int lunes = 2;
    const int martes = 3;
    const int miercoles = 4;
    const int jueves = 5;
    const int viernes = 6;
    const int sabado = 7;
    void Start()
    {
        switch (dia)
        {

            case domingo:
                Debug.Log("Domingo");
                break;
            case lunes:
                Debug.Log("Lunes");
                break;
            case martes:
                Debug.Log("Martes");
                break;
            case miercoles:
                Debug.Log("Miercoles");
                break;
            case jueves:
                Debug.Log("Jueves");
                break;
            case viernes:
                Debug.Log("Viernes");
                break;
            case sabado:
                Debug.Log("Sabado");
                break;
            default:
                Debug.Log("Esta");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
