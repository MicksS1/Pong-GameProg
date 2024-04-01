using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PRScore : MonoBehaviour
{
    public Scoring scoring;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ball")
        {
            scoring.AddScoreR();
        }
    }
}
