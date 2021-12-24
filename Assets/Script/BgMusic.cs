using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMusic : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] bgMusics = GameObject.FindGameObjectsWithTag("bgmusic");

        if(bgMusics.Length > 1)
        {
            Destroy(bgMusics[0]);
        } 

        DontDestroyOnLoad(this.gameObject);
    }
}
