using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void changeLevel()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;

        SceneManager.LoadScene(name);
    }
}
