using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource bgMusic;

    private float volume;

    private void Start()
    {
        if(PlayerPrefs.HasKey("Volume"))
        {
            volume = PlayerPrefs.GetFloat("Volume");
            volumeSlider.value = volume;
            bgMusic.volume = volume;
        }
        volumeSlider.onValueChanged.AddListener(delegate { OnVolumeChange(); });
    }

    public void OnVolumeChange()
    {
        bgMusic.volume = volumeSlider.value;
        
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
        PlayerPrefs.Save();
    }
}
