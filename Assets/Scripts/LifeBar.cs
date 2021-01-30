using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LifeBar : MonoBehaviour
{
    public Image Meter;
    public float Health ;
    public float DrainRate ;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Health = Health - (DrainRate * Time.deltaTime);
        Meter.fillAmount = Health;

        if (Health > 1f) //verifica que el valor no suba mas allá del máximo
        {
            Health = 1f;
        }

        if (Player == null)
        {
            SceneManager.LoadScene("GameOvert");

        }
    }
}
