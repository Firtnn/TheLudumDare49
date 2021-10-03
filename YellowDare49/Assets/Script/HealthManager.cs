using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int currentHealth;
    private int maxHealth = 3;
    public EmotionBar emotionBar;
    public GameObject gameOverPanel;

    public static HealthManager instance;

    private void Awake()
    {
        instance = this;
        currentHealth = maxHealth;
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (currentHealth == 0)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Health(int health)
    {
        currentHealth += health;
        emotionBar.SetEmotion(health);
    }
}
