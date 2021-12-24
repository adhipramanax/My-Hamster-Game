using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    private bool canPass;
    public key Key;
    public movement Player;

    void Start()
    {

        canPass = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Key.getKey)
        {
            canPass = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && canPass)
        {
            Player.isWin = true;
        }
    }
}
