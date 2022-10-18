using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void ExitGame()
    {
        
        Application.Quit();
        
    }
    public void SetPlayer(int index)
    {
        PlayerPrefs.SetInt("player", index);
    }
}
