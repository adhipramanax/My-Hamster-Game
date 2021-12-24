using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{

    public AudioSource BgMusic;

    // Start is called before the first frame update
    void Start()
    {
        if (!GameObject.FindGameObjectWithTag("bgmusic"))
        {
            AudioSource _bgms = Instantiate(BgMusic);
            _bgms.volume = PlayerPrefs.GetFloat("Volume");
        }
    }
}
