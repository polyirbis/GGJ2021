using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenu;

    public void EnterPause()
    {
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);
        gameObject.SetActive(false);
    }

    public void ExitPause()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
        gameObject.SetActive(true);
    }
}
