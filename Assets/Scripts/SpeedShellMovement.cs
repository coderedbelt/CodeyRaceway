using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedShellMovement : MonoBehaviour
{
    public GameObject Player;
   
    // Update is called once per frame
    void Start()
    {
        Player = GameObject.Find("Codey");
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           
            Player.GetComponent<CodeyMove>().Speed = 1900;
            Destroy(gameObject);
        }
    }

    
    
}

