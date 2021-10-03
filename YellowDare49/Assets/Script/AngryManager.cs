using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AngryManager : MonoBehaviour
{
    public int currentAngry = 0;
    public EmotionBar emotionBar;
    public CameraShake cameraShake;

    private void Update()
    {
        if (currentAngry == 2)
        {
            HealthManager.instance.Health(-1);
            currentAngry = 0;
            emotionBar.ResetBar(0);
            End.instance.Position();
            StartCoroutine(cameraShake.Shake(.15f, .25f));
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Grrr"))
        {
            Anger(1);
        }
        
    }
    
    private void Anger(int madness)
    {
        currentAngry += madness;
        emotionBar.SetEmotion(madness);
    }
}
