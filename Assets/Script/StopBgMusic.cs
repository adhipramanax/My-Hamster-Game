using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBgMusic : MonoBehaviour
{
    private void Awake()
    {
        Destroy(GameObject.FindGameObjectWithTag("bgmusic"));
    }
}
