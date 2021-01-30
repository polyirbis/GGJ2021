using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpDisplay : MonoBehaviour
{
    public GameObject HelpWindow;
    public GameObject pollen;
    public GameObject play;

    private bool IsActive = false;

    public void OpenAndClose()
    {
        if (IsActive == false)
        {
            HelpWindow.SetActive(true);

            pollen.SetActive(false);
            play.SetActive(false);
    

            IsActive = true;
        }
       else
        {
            HelpWindow.SetActive(false);

            pollen.SetActive(true);
            play.SetActive(true);
   

            IsActive = false;
        }
    }

    public void SelfClose()
    {
        gameObject.SetActive(false);
    }
}
