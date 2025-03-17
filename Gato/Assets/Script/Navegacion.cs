using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Navegacion : MonoBehaviour

{

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene("Main");
        }
        ParpadearTexto();
    }

    public Text text;
    public float parpadeo = 0.5f;

    private float time = 0f;
    private bool isVisible = true;

    public void ParpadearTexto(){
        time += Time.deltaTime;

        if (time >= parpadeo){
            isVisible = !isVisible;
            if(text != null){
                text.enabled = isVisible;
            }
            time = 0f;
        }
    }
}