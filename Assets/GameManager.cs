using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    float TimeLimit,Timer;
    [SerializeField]
    float pickableCount,pickablesToWin;
    [SerializeField]
    float currentEffectDelta,desiredEffectDelta;

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
        }else{
            Debug.Log("Player Lost");
        }
    }

    public void PickedPotion(){
        pickableCount++;
        desiredEffectDelta = (float)pickableCount/(float)pickablesToWin;
        if(pickableCount >= pickablesToWin){
            EndGame(true);
        }
    }
}
