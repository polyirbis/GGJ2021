using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public bool canAtk;

    public int cemiC;
    public int cemiP;
    public int amuA;
    public int amuP;

    public GameObject PantallaC;
    public GameObject PantallaA;
    public GameObject botonCerrar;

    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;
    public float fireRate= 15f;

    public int maxAmmo = 3;
    public int currentAmmo;
    public float reloadTime = 1f;
    private bool isrelouding = false;


    public ParticleSystem mussflassh;
    public GameObject impacefects;

    public float nextTimeToFire = 0f;

   // public Animator animator;


    void Start()
    {
        //if (currentAmmo == -1)
       // {
            currentAmmo = maxAmmo;
       // }

    }
    private void OnEnable()
    {
        isrelouding = false;
       // animator.SetBool("reloading", false);
    }
    // Update is called once per frame
    void Update()
    {

        if (PantallaA==true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Time.timeScale = 1f;
                PantallaA.SetActive(false);
            }
        }
        if (PantallaC == true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Time.timeScale = 1f;
                PantallaC.SetActive(false);
            }
        }

        if (isrelouding)
            return;

        if (currentAmmo<=0)
        {
         //  StartCoroutine( reload());
           // return;
        }

        if( canAtk == true && currentAmmo>=0)
        {
            if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1 / fireRate;
             
            }
        }
    }

    IEnumerator reload()
    {
        isrelouding = true;

        Debug.Log("Reloading");

      //  animator.SetBool("reloading", true);

        yield return new WaitForSeconds(reloadTime -.25f);

    //    animator.SetBool("reloading", false);

        yield return new WaitForSeconds(.25f);

        currentAmmo = maxAmmo;

        isrelouding = false;
    }

}
