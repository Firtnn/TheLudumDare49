using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public GameObject tutoPanel;
    public GameObject creditPanel;
    
    public void Play()
    {
        SceneManager.LoadScene("SceneGamePlay");
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void Tuto()
    {
        tutoPanel.SetActive(true);
    }
    
    
    public void QuitTuto()
    {
        tutoPanel.SetActive(false);
    }
    
    public void Credit()
    {
        creditPanel.SetActive(true);
    }
    
    
    public void QuitCredit()
    {
        creditPanel.SetActive(false);
    }
    
}
