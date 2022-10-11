using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelScript : MonoBehaviour
{



    public void Pass()
    {

        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        if (currentLevel >= PlayerPrefs.GetInt("levelreached"))
        {
            PlayerPrefs.SetInt("levelreached", currentLevel );
        }
        Debug.Log("LEVEL" + PlayerPrefs.GetInt("levelreached") + " UNLOCKED");
        SceneManager.LoadScene(1);
    }
}


