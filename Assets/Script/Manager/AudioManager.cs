using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;

    public AudioSource musicSource;
    public AudioSource sfxSource;

    public AudioClip[] sfxSounds;

    public ScriptableSong themeSong;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        musicSource.clip = themeSong.song;
        musicSource.Play();
    }

    public void PlayMusic(AudioClip song)
    {
        musicSource.clip = song;
        musicSource.Play();
    }

    public void StopMusic()
    {
        musicSource.Stop();
    }

    public void PlaySFX(int index)
    {
        sfxSource.PlayOneShot(sfxSounds[index]);
    }

    public void VolumeMusic(float volume)
    {
        musicSource.volume = volume;
    }

    public void VolumeSFX(float volume)
    {
        sfxSource.volume = volume;
    }
}
