using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{

    public GameObject[] items = new GameObject[5];

    public float moveSpeed;
    // Animator anim;
    SpriteRenderer render;
    Rigidbody2D rigid;
    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        render = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // movement 
        transform.Rotate(new Vector3(0, 0, -Input.GetAxisRaw("Horizontal2") * GetComponent<PlayerStats>().moveSpeed * GetComponent<PlayerStats>().handling * Time.deltaTime));
        transform.Translate(new Vector2(0f, Input.GetAxisRaw("Vertical2") * GetComponent<PlayerStats>().moveSpeed * Time.deltaTime));
        // if dead reset to start position and restor hp's //TODO: not hardcoded coords of spawn point
        if (GetComponent<PlayerStats>().health <= 0)
        {
            
            // drop flag if applicable and respawn at start for now //TODO drop where dies
            if (GetComponent<PlayerStats>().hasFlag == true)
            {
                GetComponent<PlayerStats>().hasFlag = false;
                items[0].SetActive(true);
            }
            //respawn
            transform.SetPositionAndRotation(pos, Quaternion.identity);
            // restore health
            GetComponent<PlayerStats>().health = 10;

            

        }
    }
    void Respawn()
    {
      
    }
}