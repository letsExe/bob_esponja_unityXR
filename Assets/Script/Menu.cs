using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private string nomeScene;
    public fadeScreen fadeScreen; // Referência ao FadeScreen

    public void Jogar()
    {
        StartCoroutine(JogarComFade()); // Chama a cena com fade
    }

    IEnumerator JogarComFade()
    {
        if (fadeScreen != null)
        {
            fadeScreen.fadeOut(); // Inicia o fade-out
            yield return new WaitForSeconds(fadeScreen.fadeDuration); // Aguarda o fade terminar
        }

        SceneManager.LoadScene(nomeScene);
    }

    public void sairJogo(){
        Application.Quit();
    }
}
