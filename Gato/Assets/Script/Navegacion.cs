using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Navegacion : MonoBehaviour
{
    public void ejecutarInicio(){
        SceneManager.LoadScene("Inicio");
    }

    public void ejecutarJuego(){
        SceneManager.LoadScene("Main");
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene("Main");
        }
    }
}