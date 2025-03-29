using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlaySoundOnClick : MonoBehaviour
{
    public AudioClip soundClip; // Som que será tocado
    private AudioSource audioSource;

    void Start()
    {
        // Adiciona um AudioSource ao objeto
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = soundClip;
        audioSource.spatialBlend = 1f; // Som 3D
    }

    // Método chamado quando o objeto for selecionado no XR Interaction Toolkit
    public void PlaySound()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
