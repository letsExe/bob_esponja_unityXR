using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasActivatorColider : MonoBehaviour
{
    public GameObject canvasToActivate; // Referência ao Canvas que será ativado

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            if (canvasToActivate != null){
                canvasToActivate.SetActive(true); // Ativa o Canvas ao colidir
            }
        }
        
    }
}
