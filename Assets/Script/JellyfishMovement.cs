using UnityEngine;

public class JellyfishMovement : MonoBehaviour
{
    public float floatSpeed = 1f;  // Velocidade do movimento vertical
    public float floatAmplitude = 0.5f; // Amplitude do sobe e desce
    public float moveSpeed = 1f; // Velocidade do deslocamento
    public float changeDirectionTime = 3f; // Tempo para mudar de direção

    private Vector3 startPosition;
    private Vector3 moveDirection;
    private float timer;

    void Start()
    {
        startPosition = transform.position;
        ChangeDirection();
    }

    void Update()
    {
        // Movimento de flutuação (sobe e desce)
        float newY = startPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        // Movimento aleatório
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // Troca de direção após um tempo
        timer += Time.deltaTime;
        if (timer >= changeDirectionTime)
        {
            ChangeDirection();
            timer = 0;
        }
    }

    void ChangeDirection()
    {
        // Define uma nova direção aleatória
        moveDirection = new Vector3(
            Random.Range(-1f, 1f), 
            0, 
            Random.Range(-1f, 1f)
        ).normalized;
    }
}
