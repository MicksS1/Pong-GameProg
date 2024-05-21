using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BotDetect : MonoBehaviour
{
    public BotMove bm;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Ball")
        {
            bm.Bot.velocity = Vector2.left * (bm.Speed * 2);
            Invoke(nameof(bm.BotRetract), 0.05f);
        }
    }
}
