using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public float moveSpeed;
    public GameObject[] items = new GameObject[5];

    // Animator anim;
    SpriteRenderer render;
    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // movement: upgrade via Playerstats: handling and speed
        transform.Rotate(new Vector3(0, 0, -Input.GetAxisRaw("Horizontal") * GetComponent<PlayerStats>().moveSpeed * GetComponent<PlayerStats>().handling * Time.deltaTime));
        transform.Translate(new Vector2(0f, Input.GetAxisRaw("Vertical") * GetComponent<PlayerStats>().moveSpeed * Time.deltaTime));
        // if dead reset to start position and restor hp's //TODO: not hardcoded coords of spawn point
        if (GetComponent<PlayerStats>().health <= 0)
        {
            
            // drop flag if applicable
            if (GetComponent<PlayerStats>().hasFlag == true)
            {
                GetComponent<PlayerStats>().hasFlag = false;
                items[1].SetActive(true);
            }
           
            // Invoke("Respawn", 3f);
            transform.SetPositionAndRotation(new Vector2(15, -15), Quaternion.identity);
            GetComponent<PlayerStats>().health = 10;
           

        }

    }

    void Respawn()
    {
      
    }
}
