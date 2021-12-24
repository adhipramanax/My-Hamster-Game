using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollection : MonoBehaviour
{
    [SerializeField] private float healthValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(healthValue > 3)
            {
                return;
            }

            collision.GetComponent<Health>().AddHealth(1);
            gameObject.SetActive(false);
        }
    }
}
