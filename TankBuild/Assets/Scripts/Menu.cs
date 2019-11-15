using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  public void PlayGame ()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ShowHelp()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
  
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("intro");
    }

}
