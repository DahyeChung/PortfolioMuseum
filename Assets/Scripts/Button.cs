using UnityEngine;
using UnityEngine.Video;

public class Button : MonoBehaviour
{

    //private AudioSource audiosource; 
    public VideoPlayer video;      
    void Start()
    {
        // Initialize components
        video.Pause(); // Ensure the video starts paused
      //  audiosource = GetComponent<AudioSource>();

        
    }

    private void OnTriggerStay(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E key pressed by Player");

              //  if (audiosource != null)
               // {
              //      audiosource.Play(); 
              //  }
//
                PlaynPause(); 
            }
        }
    }

    void PlaynPause()
    {
        if (video.isPlaying)
        {
            video.Pause();
            Debug.Log("Video Paused");
        }
        else
        {
            video.Play();
            Debug.Log("Video Playing");
        }
    }

}
