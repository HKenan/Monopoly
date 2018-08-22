
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour {
    public AudioMixer audioMixer;
    public void Setvolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
