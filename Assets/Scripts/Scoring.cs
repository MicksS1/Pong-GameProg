using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public int scoreL = 0;
    public int scoreR = 0;
    public Text pointL;
    public Text pointR;

    public void AddScoreL()
    {
        scoreL++;
        pointL.text = scoreL.ToString();
    }

    public void AddScoreR()
    {
        scoreR++;
        pointR.text = scoreR.ToString();
    }
}

