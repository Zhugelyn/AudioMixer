using UnityEngine;
using UnityEngine.Audio;


public class SoundSettings : MonoBehaviour
{
    private const string MasterSoundName = "MasterSound";
    private const string ButtonSoundName = "ButtonSound";
    private const string BackgroundSoundName = "BackgroundSound";

    [SerializeField] private AudioMixerGroup _mixer;

    public void SwitchSound(bool enabled)
    {
        if (enabled)
            _mixer.audioMixer.SetFloat(MasterSoundName, 0);
        else
            _mixer.audioMixer.SetFloat(MasterSoundName, -80);
    }

    public void SetMasterVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(MasterSoundName, Mathf.Clamp(Mathf.Log10(volume) * 20, -80, 0));
    }

    public void SetButtonVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(ButtonSoundName, Mathf.Clamp(Mathf.Log10(volume) * 20, -80, 0));
    }

    public void SetBackgroundVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(BackgroundSoundName, Mathf.Clamp(Mathf.Log10(volume) * 20, -80, 0));
    }
}
