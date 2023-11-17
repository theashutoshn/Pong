using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb.AddForce(new Vector2(20, -15));
        }
        else
        {
            rb.AddForce(new Vector2(-20, -15));
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = rb.velocity.x;
            vel.y = (rb.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            rb.velocity = vel;
        }
    }

    void ResetBall()
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = Vector2.zero;
    }

    void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }
}
