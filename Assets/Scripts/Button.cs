using UnityEngine;
using UnityEngine.Video;

public class Button : MonoBehaviour
{

    AudioSource audiosource;

    public VideoPlayer video;



    void Start()
    {
        video.Pause();
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            audiosource.Play();

            PlaynPause();

        }
    }


    void PlaynPause()
    {
        if (video.isPlaying)
        {
            video.Pause();
        }
        else
        {
            video.Play();
        }

    }



}
