using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ12 : MonoBehaviour
{
    //    En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje
    //obtenido en el lanzamiento de tres dados de un cliente, de acuerdo a los siguientes
    //resultados:
    //• Si los tres dados son seis, mostrar el mensaje “Excelente”
    //• Si dos dados son seis, mostrar el mensaje “Muy bien”
    //• Si un dado es seis, mostrar el mensaje “Regular”
    //• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente”
    // Start is called before the first frame update
    public int dado1;
    public int dado2;
    public int dado3;
    int cantseis = 0;
    const int Excelente = 3;
    const int MuyBien = 2;
    const int Regular = 1;
    const int Insuficiente = 0;
    void Start()
    {
        if (dado1 == 6)
        {
            cantseis++;
        }
        if (dado2 == 6)
        {
            cantseis++;
        }
        if (dado3 == 6)
        {
            cantseis++;
        }
        switch (cantseis)
        {
            case Excelente:
                Debug.Log("Excelente");
                break;
            case MuyBien:
                Debug.Log("Muy Bien");
                break;
            case Regular:
                Debug.Log("Regular");
                break;
            case Insuficiente:
                Debug.Log("Insuficiente");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
