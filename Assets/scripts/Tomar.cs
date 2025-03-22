using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomar : MonoBehaviour
{
    private bool tomado = false; // Para evitar llamadas múltiples
    [SerializeField] private Contador contador; // Referencia al script Contador

    private void OnTriggerEnter(Collider other)
    {
        if (!tomado && other.CompareTag("Player")) // Verifica que sea el jugador
        {
            tomado = true; // Evita que se vuelva a ejecutar
            Debug.Log($"{gameObject.name} ha sido tomado por el jugador.");

            if (contador != null)
            {
                contador.Sumar(); // Llama a la función en Contador
            }
            else
            {
                Debug.LogWarning("Contador no asignado en " + gameObject.name);
            }

            gameObject.SetActive(false); // Desactiva el objeto
        }
    }
}
