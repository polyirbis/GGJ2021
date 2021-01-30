using System.Collections;
using System.Collections.Generic;
using System.Runtime.Hosting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void Click(string EscenaAcargar)
    {
        SceneManager . LoadScene (EscenaAcargar);
        Time.timeScale = 1f;
    }
}
