
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded;
    public GameObject gameOverUI;
    public int winningPlayerNo;

    public void GameOver()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
 
            //game Over UI
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
