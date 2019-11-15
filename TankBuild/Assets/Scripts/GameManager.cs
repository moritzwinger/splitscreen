
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded;
    public GameObject gameOverUI;
    public GameObject gameOverText;
    public int winningPlayerNo;

    public void GameOver()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;

            //game Over UI
            gameOverText.GetComponent<Text>().text = "Player " + winningPlayerNo + " wins!";
            gameOverUI.SetActive(true);
            //next level
            Invoke("NextLevel", 2f);
        }
        
    }

    public void BackToMain()
    {
        //game Over UI
        gameOverText.GetComponent<Text>().text = "Player " + winningPlayerNo + " wins!";
        gameOverUI.SetActive(true);
        //back to main
        Invoke("BackToMainMenu", 2f);
    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("intro");
    }

}
