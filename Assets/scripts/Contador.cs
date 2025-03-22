using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    private int cantidad = 0; // Contador de objetos tomados
    [SerializeField] private int cantidadMaxima = 3; // Configurable en el Inspector
    [SerializeField] private GameObject objetoFinal; // Objeto que se activará

    public void Sumar()
    {
        cantidad++;
        Debug.Log($"Objetos recogidos: {cantidad}/{cantidadMaxima}");

        if (cantidad >= cantidadMaxima && objetoFinal != null)
        {
            objetoFinal.SetActive(true); // Activa el tercer objeto
            Debug.Log($"{objetoFinal.name} ha sido activado.");
        }
    }
}
