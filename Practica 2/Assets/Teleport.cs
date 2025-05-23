using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportador : MonoBehaviour
{
    [Header("Destino de teletransporte")]
    public Transform destino;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = destino.position;
            other.transform.rotation = destino.rotation; // Opcional: ajusta rotación también
        }
    }
}