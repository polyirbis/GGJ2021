using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string ToLoad = "nombre de escena";

    public void LoadLevel(string Stage1)
    {
        SceneManager.LoadScene(Stage1);
        Time.timeScale = 1f;
    }
}
