using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 5;
    public HealtBar Healthbar;
    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitpoints;
        Healthbar.SetHealth(Hitpoints,MaxHitpoints);
    }

    // Update is called once per frame
    public void TakeHit(float demage)
    {
        Hitpoints -= demage;
        Healthbar.SetHealth(Hitpoints,MaxHitpoints);
        
        if(Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
