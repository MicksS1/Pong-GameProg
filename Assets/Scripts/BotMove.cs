using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BotMove : MonoBehaviour
{
    public GameObject Ball;
    public Rigidbody2D Bot;
    public int Speed = 10;
    public float difficulty = 0.5f;
    public bool BotOver = false;

    // Update is called once per frame

    void MoveUp()
    {
        Bot.velocity = Vector2.up * Speed;
    }
    void MoveDn()
    {
        Bot.velocity = Vector2.down * Speed;
    }

    void Update()
    {
        if (Ball.transform.position.y > Bot.transform.position.y && BotOver == false)
            Invoke(nameof(MoveUp), difficulty);

        else if (Ball.transform.position.y < Bot.transform.position.y && BotOver == false)
            Invoke(nameof(MoveDn), difficulty);
    }
}
