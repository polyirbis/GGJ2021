using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Star : MonoBehaviour
{
    public Image Meter;
    public float Health;
    public float DrainRate;
    public GameObject Player;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

        if (Health > 0f) //verifica que el valor no suba mas allá del máximo
        {
            Health = Health - (DrainRate * Time.deltaTime);
            Meter.fillAmount = Health;
        }

        if (Health >= 1)
        {
            SceneManager.LoadScene("End");

        }
    }
}
