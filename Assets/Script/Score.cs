using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreCount = 0;
    public static Score instance; // Instância estática do placar
    public Text scoreText; // Referência ao texto da UI

    void Awake()
    {
        instance = this; // Define a instância para ser acessada de qualquer lugar
    }

    void Start()
    {
        UpdateScore(); // Atualiza a UI ao iniciar
    }

    public static void UpdateScore()
    {
        if (instance != null && instance.scoreText != null)
        {
            instance.scoreText.text = "Score: " + scoreCount.ToString();
        }
    }
}
