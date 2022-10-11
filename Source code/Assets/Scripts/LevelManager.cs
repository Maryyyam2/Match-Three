using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    int levelIsUnlocked;
    public Button[] buttons;
    // Start is called before the first frame update 
    void Start()
    {
        int levelreached = PlayerPrefs.GetInt("levelreached", 1);
        //levelIsUnlocked = PlayerPrefs.GetInt("levelIsUnlocked", 2);
        for (int i = 0; i < buttons.Length; i++)
        {
            if(i + 1 > levelreached )
            buttons[i].interactable = false;
        }
      
    }
      public void LoadLevel(int levelIndex)
        {
            SceneManager.LoadScene(levelIndex);
        }

}
