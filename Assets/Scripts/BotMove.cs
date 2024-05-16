using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BotMove : MonoBehaviour
{
    public GameObject Ball;
    public Rigidbody2D Bot;
    private int Speed = 10;
    public bool BotOver = false;

    // Update is called once per frame
    void Update()
    {
        if (Ball.transform.position.y > Bot.transform.position.y && BotOver == false)
            Bot.velocity = Vector2.up * Speed;
        
        else if (Ball.transform.position.y < Bot.transform.position.y && BotOver == false)
            Bot.velocity = Vector2.down * Speed;
    }
}
