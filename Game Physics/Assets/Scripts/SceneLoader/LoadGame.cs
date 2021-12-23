using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadGame : MonoBehaviour
{
   public void loadMainGame()
    {
        SceneManager.LoadScene(0);
    }

    public void loadInstructions()
    {
        SceneManager.LoadScene(2);
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
