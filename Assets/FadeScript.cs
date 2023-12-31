using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScript : MonoBehaviour
{
    private float startTime;
    private bool done = false;

    public GameObject audioParent;

    void start()
    {
        startTime = Time.time;
    }
    void Update()
    {
        CanvasGroup cg = gameObject.GetComponent<CanvasGroup>();
        float curTime = Time.time;
        cg.alpha -= (curTime - startTime) * 0.01f;

        if (!done && cg.alpha <= 0.01)
        {
            audioParent.GetComponent<AudioSource>().Play();
            done = true;
        }
    }
}
