using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;
  

    void Start()
    {
      
    }
    public void PlayGame()
    {
        buttonPress.Play();
        SceneManager.LoadScene(1);
        

    }
    public void QuitGame()
    {
        buttonPress.Play();
        Application.Quit();
    }

    public void HomeButton()
    {
        buttonPress.Play();
        SceneManager.LoadScene(0);
    }
    public void RedLev()
    {
        SceneManager.LoadScene(5);
    }
  
    
   

}
