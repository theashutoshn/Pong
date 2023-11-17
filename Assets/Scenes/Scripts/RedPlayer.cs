using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayer : MonoBehaviour
{
    private float _speed = 10f;
    private Rigidbody2D rb;
    public int score;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = rb.velocity;

        if(Input.GetKey(KeyCode.W))
        {
            velocity.y = _speed;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            velocity.y = -_speed;
        }
        else
        {
            velocity.y = 0;
        }

        rb.velocity = velocity;

        if (transform.position.y > 4.07f)
        {
            transform.position = new Vector3(transform.position.x, 4.07f, 0);
        }
        else if (transform.position.y < -4.07f)
        {
            transform.position = new Vector3(transform.position.x, -4.07f, 0);
        }
    }

    public void RedScore()
    {
        score += 10;
    }
}
