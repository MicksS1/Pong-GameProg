using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBall : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 4f;

    void StartBall()
    {
        float rand = Random.Range(0, 2);

        if (rand == 1)
            rb.velocity = Vector2.right * speed;

        else if (rand == 0)
            rb.velocity = Vector2.left * speed;
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("StartBall", 2);
    }

    public void ResetBall()
    {
        rb.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    public void RestartGame()
    {
        ResetBall();
        Invoke("StartBall", 2);
    }

    private void Update()
    {
        rb.velocity = new Vector2 (Mathf.Clamp(rb.velocity.x, -30f, 30f), Mathf.Clamp(rb.velocity.y, -15f, 15f));
    }
}
