using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pmove : MonoBehaviour
{
    public Rigidbody2D rbL;
    public Rigidbody2D rbR;
    public float speed = 10f;
    public bool over = false;

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

        if (Input.GetKeyDown(KeyCode.W) && over == false)
            rbL.velocity = Vector2.up * speed;

        else if (Input.GetKeyDown(KeyCode.S) && over == false)
            rbL.velocity = Vector2.down * speed;
            
        else if (Input.GetKeyDown(KeyCode.D) && over == false)
        {
            rbL.velocity = Vector2.right * (speed * 2);
            Invoke(nameof(PLmove), 0.05f);
        }

        // PR

        if (Input.GetKeyDown(KeyCode.UpArrow) && over == false)
            rbR.velocity = Vector2.up * speed;

        else if (Input.GetKeyDown(KeyCode.DownArrow) && over == false)
            rbR.velocity = Vector2.down * speed;

        else if (Input.GetKeyDown(KeyCode.LeftArrow) && over == false)
        {
            rbR.velocity = Vector2.left * (speed * 2);
            Invoke(nameof(PRmove), 0.05f);
        }
    }
}
