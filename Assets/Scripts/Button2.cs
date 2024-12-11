using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
   

    public AudioSource Music;
    public AudioSource Lobby;



    void Start()
    {
        Music.Pause();
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
               
                PlaynPause();
            }
        }
    }


    void PlaynPause()
    {
        if (Music.isPlaying)
        {
            Music.Pause();
            Lobby.Play();
        }
        else
        {
            Music.Play();
            Lobby.Pause();
        }

    }



}
