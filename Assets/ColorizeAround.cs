using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorizeAround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Shader.SetGlobalFloat("_PlayerRadius",15);
    }

    // Update is called once per frame
    void Update()
    {
        Shader.SetGlobalVector("_PlayerPosition",new Vector4(transform.position.x,transform.position.y,transform.position.z,1));
    }
}
