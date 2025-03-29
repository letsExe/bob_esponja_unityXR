using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    [SerializeField] private GameObject playerXR; // XR Origin (Jogador)
    [SerializeField] private GameObject cam; // Câmera alternativa (ex: cadeira)
    private bool isSwitched = false;
    public float switchDuration = 7f; // Tempo antes de voltar à câmera do jogador

    void Start()
    {
        cam.SetActive(false); // Garante que a câmera alternativa comece desligada
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isSwitched) // Certifique-se de que o XR Rig tem essa Tag
        {
            SwitchCamera();
        }
    }

    private void SwitchCamera()
    {
        isSwitched = true; // Evita múltiplas ativações

        // Troca para a câmera alternativa
        playerXR.GetComponentInChildren<Camera>().enabled = false;
        cam.SetActive(true);

        // Voltar para a câmera do jogador após 7 segundos
        Invoke("ResetCamera", switchDuration);
    }

    private void ResetCamera()
    {
        // Volta para a câmera do jogador
        playerXR.GetComponentInChildren<Camera>().enabled = true;
        cam.SetActive(false);

        isSwitched = false; // Permite que o jogador ative de novo ao tocar
    }
}
