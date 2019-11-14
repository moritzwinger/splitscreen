
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded;
    public GameObject gameOverUI;

    public void GameOver()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            // display game over
            Debug.Log("Game Over");
            //Restart game
            gameOverUI.SetActive(true);
            Invoke("Restart", 2f);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
