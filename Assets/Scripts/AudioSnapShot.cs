using UnityEngine;
using UnityEngine.Audio;

public class AudioSnapShot : MonoBehaviour
{
    public AudioMixer MainAudioMixer;
    public AudioMixerSnapshot NormalSnapShot;
    public AudioMixerSnapshot UnderwaterSnapShot;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            ApplyAudioSnapshot(UnderwaterSnapShot, 1.0f);
        }
    }

    public void ApplyAudioSnapshot(AudioMixerSnapshot snapshot, float translationTime)
    {
        snapshot.TransitionTo(translationTime);
        //underWater.TransitionTo(0.2f);

    }
}
