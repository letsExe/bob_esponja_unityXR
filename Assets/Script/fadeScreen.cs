using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeScreen : MonoBehaviour
{
    public bool fadeOnStart = true;
    public float fadeDuration = 2f;
    public Color fadeColor;
    private Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        if(fadeOnStart)
            fadeIn();
    }

    public void fadeIn ()
    {
        Fade(1, 0);
    }

    public void fadeOut()
    {
        Fade(0, 1);
    }

    public void Fade(float alphaIn, float alphaOut)
    {
        StartCoroutine(FadeRoutine(alphaIn, alphaOut));

    }

    public IEnumerator FadeRoutine(float alphaIn, float alphaOut){
        float timer = 0;
        while(timer <= fadeDuration){

            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timer / fadeDuration);

            rend.material.SetColor("_Color", newColor);

            timer += Time.deltaTime;
            yield return null;
        }

        Color newColor2 = fadeColor;
        newColor2.a = alphaOut;

        rend.material.SetColor("_Color", newColor2);
    }
}
