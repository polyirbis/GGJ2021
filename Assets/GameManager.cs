using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    float TimeLimit,Timer;
    [SerializeField]
    float pickableCount,pickablesToWin;
    [SerializeField]
    float currentEffectDelta,desiredEffectDelta;
    [SerializeField]
    Text TimerText,Pickables;
    [SerializeField]
    string victoryScene,DefeatScene;

    bool Running;
    // Start is called before the first frame update
    void Start()
    {
        Shader.SetGlobalFloat("_ColorAmount",0);
        Timer = 0;
        Running = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Running){
            Timer += Time.deltaTime;
            if(TimerText != null){
                int timeInSecondsInt = (int)Timer;  //We don't care about fractions of a second, so easy to drop them by just converting to an int
            int minutes = (int)Timer / 60;  //Get total minutes
            int seconds = timeInSecondsInt - (minutes * 60);  //Get seconds for display alongside minutes
            TimerText.text = minutes.ToString("D2") + ":" + seconds.ToString("D2");  //Create the string representation, where both seconds and minutes are at minimum 2 digits

            }
            if(Timer > TimeLimit){
                if(pickableCount>=pickablesToWin){
                    EndGame(true);
            }
                else{
                    EndGame(false);
            }
            
        }
        currentEffectDelta = Mathf.Lerp(currentEffectDelta,desiredEffectDelta,Time.deltaTime*0.5f);
        Shader.SetGlobalFloat("_ColorAmount",currentEffectDelta);
        }

    }
    void StartGame(){
        Running = true;
        Debug.Log("Player won!");
    }

    void EndGame(bool outcome){
        Running = false;
        if(outcome == true){
            Debug.Log("Player Won!");
            SceneManager.LoadScene(victoryScene);
        }else{
            Debug.Log("Player Lost");
            SceneManager.LoadScene(DefeatScene);
        }
    }

    public void PickedPotion(){
        pickableCount++;
        desiredEffectDelta = (float)pickableCount/(float)pickablesToWin;
        if(Pickables != null){
            Pickables.text = pickableCount.ToString();
        }
        if(pickableCount >= pickablesToWin){
            EndGame(true);
        }
    }
}
