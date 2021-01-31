using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AdvancedCharacterController;

public class AnimatorDrive : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    Vector3 pos,lastPos,vel,normalizedVel;
    [SerializeField]
    float maxSpeed;
    [SerializeField]
    float velToDrive;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lastPos != transform.position) {
        vel = transform.position - lastPos;
        vel /= Time.deltaTime;
        lastPos = transform.position;
    }
    normalizedVel = (1/maxSpeed) * vel;
    velToDrive = normalizedVel.magnitude;
    animator.SetFloat("Speed",velToDrive);
    }
}
