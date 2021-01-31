using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public CharacterController controller;


    public bool CanMove = true;
    public int HP;
  //  public GameObject GammeOverP;

    public float speed;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float bendHeight = -1f;

   // public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    public bool isGrounded;

  

    public void TakeDamage(int amunt)
    {
        HP -= amunt;

        if (HP <= 0f)
        {
            Debug.Log("die");
            Die();
         //   GammeOverP.SetActive(true);
            Time.timeScale = 0f;
            CanMove = false;
        }
    }

    void Die()
    {
        //Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (CanMove == true) { 

 //       isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
   
        }
    //    if (GammeOverP == true)
     //   {
        //    if (Input.GetButtonDown("Fire2"))
       //     {
       //         Time.timeScale = 1f;
       //         Debug.Log("restart");
       //         SceneManager.LoadScene("Testlv");
        //        GammeOverP.SetActive(false);
      //      }
      //  }

        if (Input.GetButtonDown("Cancel"))

        {
            Application.Quit();
            Debug.Log("exit");
        }

 
    }
}
