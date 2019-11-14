using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // pick up flag
        if (collision.gameObject.name == "Flag1")
        {
            Debug.Log("Picked up player 1 flag");
            collision.gameObject.SetActive(false);
            gameObject.GetComponent<PlayerStats>().hasFlag = true;
            // TODO add something that shows flag on tank
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Win the game if flag is dropped at the drop zone
        if (collision.gameObject.tag == "Drop2" && gameObject.GetComponent<PlayerStats>().hasFlag == true)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
