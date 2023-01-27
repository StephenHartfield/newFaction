using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overlay : MonoBehaviour
{
    public float fadeTiming;
    private float fadeTimer;
    private Image overlay;

    void Awake()
    {
        fadeTimer = .7f;
        overlay = transform.GetComponent<Image>();
    }

    void Update()
    {
        if ( fadeTimer > 0 )
        {
            fadeTimer -= Time.deltaTime;
        }
        else
        {
            StartCoroutine(FadeOut(overlay));
            gameObject.SetActive( false );
        }
    }

    private YieldInstruction fadeInstruction = new YieldInstruction();
    IEnumerator FadeOut(Image image)
    {
        float elapsedTime = 0.0f;
        Color c = image.color;
        while (elapsedTime < fadeTiming)
        {
            yield return fadeInstruction;
            elapsedTime += Time.deltaTime ;
            c.a = 1.0f - Mathf.Clamp01(elapsedTime / fadeTiming);
            image.color = c;
        }
    }
}
