using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public float Speed = 4.5f;

    public void Update() {
        transform.position += -transform.right * Time.deltaTime * Speed;
    }

    public void OnCollisionEnter2D(Collision2D collision) {
           var enemy = collision.collider.GetComponent<EnemyBehaviour>();
        if(enemy){
            enemy.TakeHit(1);
        }
        Destroy(gameObject);
    }
}
