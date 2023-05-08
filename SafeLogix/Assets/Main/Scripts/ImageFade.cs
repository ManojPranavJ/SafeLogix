using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFade : MonoBehaviour
{
    public Image[] images;
    public float fadeTime = 1.0f;
    public float pauseTime = 2.0f;

    private int currentIndex = 0;

    void Start()
    {
        StartCoroutine(FadeImages());
    }

    IEnumerator FadeImages()
    {
        while (true)
        {
            // fade in current image
            images[currentIndex].CrossFadeAlpha(1.0f, fadeTime, false);

            // wait for pause time
            yield return new WaitForSeconds(pauseTime);

            // fade out current image
            images[currentIndex].CrossFadeAlpha(0.0f, fadeTime, false);

            // move to next image
            currentIndex = (currentIndex + 1) % images.Length;
        }
    }
}
