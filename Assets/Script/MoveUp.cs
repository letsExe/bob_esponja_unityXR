using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MoveUp : MonoBehaviour
{
    public float moveSpeed = 2f; // Velocidade do movimento
    public float rotationSpeed = 50f;
    private bool isMoving = false;

    public void MoveObjectUp()
    {
        isMoving = true; // Ativa o movimento
    }

    void Update()
    {
        if (isMoving)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime; // Faz o objeto subir constantemente

            // Faz o objeto girar continuamente no eixo Y
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}
