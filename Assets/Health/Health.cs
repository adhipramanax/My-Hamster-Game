using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth{ get; private set;}
    private Animator anim;
    public bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDemage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        if(currentHealth >0)
        {
            Debug.Log("Aduh");
            anim.SetTrigger("hurt");
        }
        else
        {
            if (!dead)
            {
                Debug.Log("Mati");
                anim.SetTrigger("die");
                GetComponent<Animator>().enabled = false;
                dead = true;
            }
        }
    }
    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }

}
