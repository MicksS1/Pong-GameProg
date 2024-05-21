using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotMove : MonoBehaviour
{
    public GameObject Ball;
    public Rigidbody2D Bot;
    public int Speed = 10;
    private float delay; // <- difficulty
    public bool BotOver = false;

    // delay easy = 0.2f, smash off
    // delay medium = 0.075f
    // delay hard = 0f

    // Update is called once per frame

    private void Start()
    {
        Scene activeScene = SceneManager.GetActiveScene();

        if (activeScene.name == "PvCScene_Easy")
            delay = 0.2f;

        else if (activeScene.name == "PvCScene_Med")
            delay = 0.075f;

        else if (activeScene.name == "PvCScene_Hard")
            delay = 0f;

        Debug.Log(delay);
    }

    void SetOverFalse()
    {
        BotOver = false;
    }
    void MoveUp()
    {
        Bot.velocity = Vector2.up * Speed;
    }
    void MoveDn()
    {
        Bot.velocity = Vector2.down * Speed;
    }

    public void BotRetract()
    {
        Bot.velocity = Vector2.right * (Speed * 2);
        Invoke(nameof(SetOverFalse), 0.05f);
    }

    void Update()
    {
        if (Ball.transform.position.y > Bot.transform.position.y && BotOver == false)
            Invoke(nameof(MoveUp), delay);

        else if (Ball.transform.position.y < Bot.transform.position.y && BotOver == false)
            Invoke(nameof(MoveDn), delay);
    }

    // WIP (mau bikin bot ny bisa smash. Smash bekerja dengan baik kalau delayiculty = 0, klo 0.075 lgsg rusak dikit)

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (delay == 0.075f || delay == 0f)
            if (coll.gameObject.tag == "Ball" )
            {

                BotOver = true;
                Bot.velocity = Vector2.left * (Speed * 2);

                if (delay == 0f)
                    Invoke(nameof(BotRetract), 0.05f);
                else
                    Invoke(nameof(BotRetract), 0.06f);
            }
    }
}
