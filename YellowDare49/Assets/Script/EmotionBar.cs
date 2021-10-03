using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;

public class EmotionBar : MonoBehaviour
{
    [HideInInspector]
    public Slider slider;
    void Start()
    {
        slider = GetComponent<Slider>();
    }
    
    public void SetEmotion(float emotion)
    {   
        slider.value += emotion;
    }

    public void ResetBar(float emotion)
    {
        slider.value = emotion;
    }
}
