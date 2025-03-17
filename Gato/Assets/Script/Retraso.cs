using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambiarEscenaConRetraso : MonoBehaviour
{
    public string Inicio;
    public float retraso = 1f; // Duración del audio

        //Metodo para retrasar boton regresar
    public void Regresar()
    {
        Invoke("CargarEscena", retraso);
    }

    void CargarEscena()
    {
        SceneManager.LoadScene("Inicio");
    }
        //Metodo para retrasar boton reiniciar
    public void Reiniciar()
    {
        Invoke("CargarIniciar", retraso);
    }

    void CargarIniciar()
    {
        SceneManager.LoadScene("Main");
    }
}