using System.Collections;
using System.Collections.Generic;
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
    public GameObject GO;
    public GameObject Ball;

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
        if (scoring.scoreL == 7 || scoring.scoreR == 7)
        {
            GO.SetActive (true);
            PLMove.over = true;
            PRMove.over = true;

            Ball.SetActive (false);
        }
    }

    public void RestartG()
    {
        goball.RestartGame();

        PL.transform.position = new Vector2(-8.294f, 0);
        PR.transform.position = new Vector2(8.294f, 0);

        scoring.scoreL = 0;
        scoring.scoreR = 0;

        scoring.pointL.text = scoring.scoreL.ToString();
        scoring.pointR.text = scoring.scoreR.ToString();

        Ball.SetActive(true);
        GO.SetActive(false);

        PLMove.over = false;
        PRMove.over = false;
    }
}
