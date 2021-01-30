using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public float Score;

    public float EarningRate; //la velocidad a la que el puntaje aumenta con el tiempo
    public bool onScore;
    public GameObject Continue;

    public float Score1;
    public GameObject Reward1;
    public float Score2;
    public GameObject Reward2;
    public float Score3;
    public GameObject Reward3;
    public float Score4;
    public GameObject Reward4;

    public Text Text;
    public GameObject Player;

    public bool eventSent = false;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        onScore = true;
    }

    void ChangeScore()
    {
        // changeScore
        //  if (Score > 100 && !eventSent)
     //   {
            //eventSent = true;
       //     Time.timeScale = 0f;
     //       Continue.SetActive(true);
         //   Reward1.SetActive(true);
        //    Debug.Log("hota");
            // Do something
      //  }
    }


    void Update()
    {
        ChangeScore(); 

        if(onScore == true)
        {
            Score += Time.deltaTime * EarningRate;

            Text.text = Score.ToString("f0") + " pts.";
        }

        if (Player == null)
        {
            PlayerPrefs.SetFloat("CurrentScore", Score);
            if (Score > PlayerPrefs.GetFloat("HighScore", 0f))
            {
                PlayerPrefs.SetFloat("HighScore", Score);
            }
        }
    }
}
