using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CanvasActivator : MonoBehaviour
{
    public GameObject targetCanvas; // Referência ao Canvas que será ativado

    public void ToggleCanvas()
    {
        if (targetCanvas != null)
        {
            bool isActive = targetCanvas.activeSelf; // Verifica se já está ativo
            targetCanvas.SetActive(!isActive); // Alterna entre ligado/desligado
        }
    }
}
