using UnityEngine;

public class Jellyfish : MonoBehaviour
{
    private bool alreadyCounted = false; // Para evitar múltiplas contagens

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rede") && !alreadyCounted)
        {
            alreadyCounted = true; // Marca que já contou essa água-viva
            Score.scoreCount += 1;
            Score.UpdateScore();

            GetComponent<Collider>().enabled = false; // Desativa o Collider para evitar novas colisões
            Destroy(gameObject, 0.1f); // Dá um pequeno delay antes de destruir
        }
    }
}
