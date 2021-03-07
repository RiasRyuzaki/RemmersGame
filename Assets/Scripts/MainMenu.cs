using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("koniec");
    }
    public void LevelSelector()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void MainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
