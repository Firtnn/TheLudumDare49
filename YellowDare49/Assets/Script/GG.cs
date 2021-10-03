using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GG : MonoBehaviour
{    
    public GameObject ggPanel;
    private BoxCollider2D _collider;
    private float timer;
    public Text text;
    private void Awake()
    {
        _collider = GetComponent<BoxCollider2D>();
        text = text.GetComponent<Text>();
    }
    
    private void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0;
            ggPanel.SetActive(true);
            text.text = timer.ToString();
        }
    }
}
