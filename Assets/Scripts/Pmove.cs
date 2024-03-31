using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pmove : MonoBehaviour
{
    public Rigidbody2D rbL;
    public Rigidbody2D rbR;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void PLmove() 
    {
        rbL.velocity = Vector2.left * (speed * 2);
    }

    void PRmove()
    {
        rbR.velocity = Vector2.right * (speed * 2);
    }

    // Update is called once per frame
    void Update()
    {
        // PL

        if (Input.GetKey(KeyCode.W))
            rbL.velocity = Vector2.up * speed;

        else if (Input.GetKey(KeyCode.S))
            rbL.velocity = Vector2.down * speed;
            
        else if (Input.GetKeyDown(KeyCode.D))
        {
            rbL.velocity = Vector2.right * (speed * 2);
            Invoke(nameof(PLmove), 0.05f);
        }

        // PR

        if (Input.GetKey(KeyCode.UpArrow))
            rbR.velocity = Vector2.up * speed;

        else if (Input.GetKey(KeyCode.DownArrow))
            rbR.velocity = Vector2.down * speed;

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rbR.velocity = Vector2.left * (speed * 2);
            Invoke(nameof(PRmove), 0.05f);
        }
    }
}
