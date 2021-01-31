using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTest : MonoBehaviour
{
    float t,t2;
    [SerializeField]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        t2 = Mathf.Sin(t*1/speed);
        Shader.SetGlobalFloat("_ColorAmount",t2);
    }
}
