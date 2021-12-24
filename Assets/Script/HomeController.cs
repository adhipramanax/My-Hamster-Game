using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeController : MonoBehaviour
{
    public void onPressed()
    {
        SceneManager.LoadScene("menu");
    }
}
