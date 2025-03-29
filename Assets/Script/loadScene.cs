using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public fadeScreen fadeScreen;

    public void goToScene(int sceneIndex)
    {
        //StartCoroutine(goToScene(sceneIndex));
    }

    IEnumerator goToSceneRoutine(int sceneIndex)
    {
        fadeScreen.fadeOut();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);
        SceneManager.LoadScene(sceneIndex);
    }
    
 
}
