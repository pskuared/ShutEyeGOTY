using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Button is working.");
        SceneManager.LoadScene("IntroCutscene");
        Time.timeScale = 1f;
    }

     public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
