using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // hit explosion effect: instantiate and destroy after a second
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        //destroy bullet
        Destroy(gameObject);
        // deduct hp from object that has been hit
        collision.gameObject.GetComponent<PlayerStats>().health -= 5;
    }
}

