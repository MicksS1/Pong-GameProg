using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    public GoBall goball;
    public GameObject PL;
    public GameObject PR;
    public Scoring scoring;
    public Pmove PLMove;
    public Pmove PRMove;
    public BotMove BMove;
    public GameObject GO;
    public GameObject OrWin;
    public GameObject BlWin;
    public GameObject Ball;
    public int ScoreToWin = 100;

    public void ChangeScene (string sceneName)
    {
        SceneManager.LoadScene (sceneName);
    }

    public void QuitApp()
    {
        Application.Quit ();
    }

    public void Update()
    {

        if (scoring.scoreL >= ScoreToWin)
        {
            GO.SetActive (true);
            BlWin.SetActive (true);

            PLMove.over = true;

            if (PRMove != null)
                PRMove.over = true;

            if (BMove != null)
                BMove.BotOver = true;
            
            Ball.SetActive(false);
        }
        
        if (scoring.scoreR >= ScoreToWin) 
        {
            GO.SetActive (true);
            OrWin.SetActive (true);

            PLMove.over = true;

            if (PRMove != null)
                PRMove.over = true;

            if (BMove != null)
                BMove.BotOver = true;

            Ball.SetActive(false);
        }
    }

    public void RestartG()
    {
        //goball.RestartGame();

        //PL.transform.position = new Vector2(-8.294f, 0);
        //PR.transform.position = new Vector2(8.294f, 0);

        //scoring.scoreL = 0;
        //scoring.scoreR = 0;

        //scoring.pointL.text = scoring.scoreL.ToString();
        //scoring.pointR.text = scoring.scoreR.ToString();

        //Ball.SetActive(true);
        //GO.SetActive(false);
        //OrWin.SetActive (false);
        //BlWin.SetActive (false);

        //PLMove.over = false;
        //PRMove.over = false;

        SceneManager.LoadScene("GameScene");
    }

    public void RestartPvC_Easy()
    {
        SceneManager.LoadScene("PvCScene_Easy");
    }

    public void RestartPvC_Med()
    {
        SceneManager.LoadScene("PvCScene_Med");
    }

    public void RestartPvC_Hard()
    {
        SceneManager.LoadScene("PvCScene_Hard");
    }
}
