using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTest : MonoBehaviour
{
    float t,t2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        t2 = Mathf.Sin(t*0.5f);
        Shader.SetGlobalFloat("_ColorAmount",t2);
    }
}
