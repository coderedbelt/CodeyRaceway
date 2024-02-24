using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementshell : MonoBehaviour
{
    public GameObject Enemy;
    

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right;  
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
