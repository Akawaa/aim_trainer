using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public Shoot shootscript;

    public Text ScoreTxt;
    public Text AccuracyTxt;

    void Start()
    {
        ScoreTxt.text = "Score: " + Shoot.totalscore.ToString();
        AccuracyTxt.text = Shoot.totalaccuracy.ToString() + "% Accuracy";
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
