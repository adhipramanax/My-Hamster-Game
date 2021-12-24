using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public bool getKey;
    private GameObject keyUI;

    // Start is called before the first frame update
    void Start()
    {
        getKey = false;

        keyUI = GameObject.FindWithTag("keyUI");

        keyUI.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            keyUI.SetActive(true);
            getKey = true;

            this.gameObject.SetActive(false);
        }
    }
}
