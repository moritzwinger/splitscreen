
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
            //Restart game
            Invoke("Restart", 2f);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
