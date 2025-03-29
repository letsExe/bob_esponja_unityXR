using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string sceneName; // Nome da cena a ser carregada
    public fadeScreen fadeScreen; // Referência ao script de fade

    public void GoToScene(int sceneIndex)
    {
        StartCoroutine(GoToSceneRoutine(sceneIndex)); // Chamada correta da Coroutine
    }

    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        if (fadeScreen != null)
        {
            fadeScreen.fadeOut(); // Inicia o efeito de fade
            yield return new WaitForSeconds(fadeScreen.fadeDuration); // Aguarda o fade terminar
        }

        SceneManager.LoadScene(sceneIndex);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(GoToSceneRoutineByName()); // Chama a cena pelo nome
        }
    }

    IEnumerator GoToSceneRoutineByName()
    {
        if (fadeScreen != null)
        {
            fadeScreen.fadeOut();
            yield return new WaitForSeconds(fadeScreen.fadeDuration);
        }

        SceneManager.LoadScene(sceneName);
    }
}
