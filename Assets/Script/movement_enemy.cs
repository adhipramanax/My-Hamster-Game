using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_enemy : MonoBehaviour
{
    public float movementSpeed = 1;
    public float movement = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        if (!Mathf.Approximately(0, movement)) {
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
    }
}
