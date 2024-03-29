using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayer : MonoBehaviour
{
    private float _speed = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = rb.velocity;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity.y = _speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
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
}
