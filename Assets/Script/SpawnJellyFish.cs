using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnJellyFish : MonoBehaviour
{
    public GameObject aguaVivaPrefab; // Prefab da água-viva
    public int quantidade = 25; // Número de águas-vivas
    public float spawnRadius = 3f; // Distância máxima ao redor da água-viva original

    void Start()
    {
        SpawnJelly();
    }

    void SpawnJelly()
    {
        // Encontra uma água-viva existente na cena
        GameObject existingJellyfish = GameObject.FindWithTag("JellyFish");

        if (existingJellyfish != null) // Se encontrou uma água-viva original
        {
            Vector3 basePosition = existingJellyfish.transform.position; // Posição base da água-viva original

            for (int i = 0; i < quantidade; i++)
            {
                // Gera um ponto próximo à água-viva original dentro de um raio definido
                Vector3 spawnOffset = new Vector3(
                    Random.Range(-spawnRadius, spawnRadius),
                    Random.Range(-1f, 1f),  // Pequena variação na altura
                    Random.Range(-spawnRadius, spawnRadius)
                );

                Vector3 spawnPosition = basePosition + spawnOffset; 

                Instantiate(aguaVivaPrefab, spawnPosition, aguaVivaPrefab.transform.rotation);
            }
        }
        else
        {
            Debug.LogWarning("Nenhuma água-viva original encontrada na cena!");
        }
    }
}

