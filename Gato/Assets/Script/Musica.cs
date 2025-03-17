using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    private AudioSource music;
    public AudioClip ClickX;
    public AudioClip ClickO;
    public AudioClip ClickRegresar;   
    public AudioClip Ganador; 
    void Start()
    {
        music = GetComponent<AudioSource>();

    }

    public void ClickAudioX(){
        music.PlayOneShot(ClickX);
    }

    public void ClickAudioO(){
        music.PlayOneShot(ClickO);
    }

    public void ClickAudioRegresar(){
        music.PlayOneShot(ClickRegresar);
    }

    public void GanadorAudio(){
        music.PlayOneShot(Ganador);
    }

}
