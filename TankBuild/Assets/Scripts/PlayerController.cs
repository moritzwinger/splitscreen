using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public float moveSpeed;
    public GameObject[] items = new GameObject[5];
    public Vector3 pos;

    // Animator anim;
    SpriteRenderer render;
    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        //startingpos
        pos = transform.position;

        render = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // movement: upgrade via Playerstats: handling and speed
        transform.Rotate(new Vector3(0, 0, -Input.GetAxisRaw("Horizontal") * GetComponent<PlayerStats>().moveSpeed * GetComponent<PlayerStats>().handling * Time.deltaTime));
        transform.Translate(new Vector2(0f, Input.GetAxisRaw("Vertical") * GetComponent<PlayerStats>().moveSpeed * Time.deltaTime));
        
        // if dead reset to start position and restor hp's 
        if (GetComponent<PlayerStats>().health <= 0)
        {
            
            // drop flag if applicable
            if (GetComponent<PlayerStats>().hasFlag == true)
            {
                GetComponent<PlayerStats>().hasFlag = false;
                items[1].SetActive(true);
            }
            // respawn
            transform.SetPositionAndRotation(pos, Quaternion.identity);
            // restore health
            GetComponent<PlayerStats>().health = 10;
           

        }

    }

}
