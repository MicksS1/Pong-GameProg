using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PRScore : MonoBehaviour
{
    public Scoring scoring;
    public GameObject PPV;
    // private Bloom bloom;

    private void Start()
    {
        // bloom = PPV.GetComponent<Bloom>();
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ball")
        {
            scoring.AddScoreR();
            //bloom.intensity = 5f;
        }
    }
}
