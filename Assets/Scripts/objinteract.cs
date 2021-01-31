using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objinteract : MonoBehaviour

{
    public inventario Inventario;
    public Gun Inventariogun;
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
            
        }
    }

}
