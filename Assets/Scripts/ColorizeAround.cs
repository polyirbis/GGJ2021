using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorizeAround : MonoBehaviour
{
    Vector3 pos;
    [SerializeField]
    float radius,followSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Shader.SetGlobalFloat("_PlayerRadius",radius);
    }

    // Update is called once per frame
    void Update()
    {
        radius= Mathf.Abs(radius);
        Shader.SetGlobalFloat("_PlayerRadius",radius);
        pos = Vector3.Lerp(pos,transform.position, Time.deltaTime * followSpeed);
        Shader.SetGlobalVector("_PlayerPosition",new Vector4(pos.x,pos.y,pos.z,1));
    }
}
