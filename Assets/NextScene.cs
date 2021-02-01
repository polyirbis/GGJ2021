using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene : MonoBehaviour
{
    [SerializeField]
    string SceneToLoad;
    [SerializeField]
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Shader.SetGlobalFloat("_ColorAmount",1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown){
            audioSource.Play();
            Invoke("LoadNextScene",2f);
        }
    }

    void LoadNextScene(){
        SceneManager.LoadScene(SceneToLoad);
        
    }
}
