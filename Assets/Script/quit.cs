using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    void Update()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
