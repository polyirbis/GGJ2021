using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objinteract : MonoBehaviour

{
    public inventario Inventario;
    public Gun Inventariogun;
    public bool cemi;
    public bool arAF;
   // public AudioClip discoverFVX;
    public new AudioSource audio;
    public float volumen;


    // Start is called before the first frame update
    void Start()
    {
        Inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<inventario>();
        // Inventariogun = GameObject.FindGameObjectWithTag("Gun").GetComponent<Gun>();

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Inventario.cantidad = Inventario.cantidad + 1;
            // GetComponent<AudioSource>().PlayOneShot(discoverFVX, volumen);
          audio.Play();

            Debug.Log("VFXOBJ");


            if (cemi == true)
            {
                //    Inventariogun.cemiC = Inventariogun.cemiC + 1;
                //    if (Inventariogun.cemiC == Inventariogun.cemiP)
                //    {
                //       Inventariogun.canAtk = true;
                //         Inventariogun.PantallaC.SetActive(true);
                //  Inventariogun.botonCerrar.SetActive(true);
                Time.timeScale = 0f;
            }

        }
        if (arAF == true)
        {
            // Inventariogun.amuA = Inventariogun.amuA + 1;

            //    if (Inventariogun.amuA == Inventariogun.amuP)
            //  {
            //       Inventariogun.currentAmmo = +5;
            //     Inventariogun.PantallaA.SetActive(true);
            //  Inventariogun.botonCerrar.SetActive(true);
            Time.timeScale = 0f;
        }
        Destroy(gameObject);
    }

}
