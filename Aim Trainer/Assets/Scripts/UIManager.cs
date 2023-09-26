using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    public Shoot shootscript;

    public Text TimerTxt;
    public Text ScoreTxt;
    public Text AccuracyTxt;
    

    void Start()
    {
        TimerOn = true;
    }

    void Update()
    {
        ScoreTxt.text = "Score: " + shootscript.score.ToString();
        AccuracyTxt.text = shootscript.accuracy.ToString() + "%";
        if (TimerOn)
        {
            if(TimeLeft < 0)
            {
                Shoot.totalscore = shootscript.score;
                Shoot.totalaccuracy = shootscript.accuracy;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{00}", seconds);
    }
}
