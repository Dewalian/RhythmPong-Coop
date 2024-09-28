using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;

    public void VolumeMusic()
    {
        AudioManager.instance.VolumeMusic(musicSlider.value);
    }

    public void VolumeSFX()
    {
        AudioManager.instance.VolumeSFX(sfxSlider.value);
    }
}
