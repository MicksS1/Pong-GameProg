using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBall : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        float rand = Random.Range(0, 2);

        if (rand == 1)
            rb.velocity = Vector2.right * speed;

        else if (rand == 0)
            rb.velocity = Vector2.left * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
