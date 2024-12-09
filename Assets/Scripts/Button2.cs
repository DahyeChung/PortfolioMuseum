using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    AudioSource audiosourceclick;

    public AudioSource Music;



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
        if (Input.GetKeyDown(KeyCode.E))
        {
            audiosourceclick.Play();

            PlaynPause();

        }
    }


    void PlaynPause()
    {
        if (Music.isPlaying)
        {
            Music.Pause();
        }
        else
        {
            Music.Play();
        }

    }



}
