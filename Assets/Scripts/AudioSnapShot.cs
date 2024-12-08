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
public class AudioSnapshotSwitcher : MonoBehaviour
{
    public AudioMixer audioMixer; // Reference to the Audio Mixer
    public AudioMixerSnapshot NormSnapshot;
    public AudioMixerSnapshot DarkSnapshot;
    public AudioMixerSnapshot Ambient2Snapshot;
    public AudioMixerSnapshot BattleSnapshot;
    public AudioMixerSnapshot HiddenitemSnapshot;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ApplyAudioSnapshot(NormSnapshot, 1.5f); // Transition time for Alpha1 is 1.5 seconds
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ApplyAudioSnapshot(DarkSnapshot, 2.0f); // Transition time for Alpha2 is 2 seconds
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ApplyAudioSnapshot(Ambient2Snapshot, 1.5f); // Transition time for Alpha3 is 1.5 seconds
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ApplyAudioSnapshot(BattleSnapshot, 3.0f); // Transition time for Alpha4 is 3 seconds
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            ApplyAudioSnapshot(HiddenitemSnapshot, 3.0f); // Transition time for Alpha5 is 3 seconds
        }
    }
    private void ApplyAudioSnapshot(AudioMixerSnapshot snapshot, float transitionTime)
    {
        snapshot.TransitionTo(transitionTime); // Transition to the specified snapshot with the specified transition time
    }
}