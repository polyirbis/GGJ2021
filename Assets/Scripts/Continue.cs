using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
   public GameObject Reward1;
    public void ExitPause()
    {
        Time.timeScale = 1f;
        Reward1.SetActive(false);
        gameObject.SetActive(false);
        
    }
}
