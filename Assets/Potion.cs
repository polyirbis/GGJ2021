using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    enum State{
        Instanced,
        PickedUp
    }
    State potionState;

    GameManager gameManager;
    [SerializeField]
    float rotationSpeed;
    //[SerializeField]
   // GameObject particle, Visual;
    [SerializeField]
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        potionState = State.Instanced;
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePotion();
    }

    void RotatePotion()
    {
        transform.Rotate(0,rotationSpeed*Time.deltaTime,0,Space.World);

    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player") && potionState == State.Instanced){
            PickUp();
        }
    }

    void PickUp(){
        // particle.SetActive(true);
        animator.SetBool("Desaparecer", true);
        potionState = State.PickedUp;
        gameManager.PickedPotion();
        Invoke("Disappear",2f);
    }

    void Disappear(){
        //Visual.SetActive(false);
        Invoke("TurnOff",1f);
    }

    void TurnOff(){
        gameObject.SetActive(false);
    }



}
