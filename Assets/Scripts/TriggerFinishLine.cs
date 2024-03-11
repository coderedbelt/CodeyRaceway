using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinishLine : MonoBehaviour
{

    public CheckpointCounter checkpointTracker;
    public GameObject YouWonCanvas;

    void Start()
    {
        YouWonCanvas.SetActive(false);
    }
   

    

    private void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
            {
                print("You Win!");
                YouWonCanvas.SetActive(true);
                Time.timeScale = 0;


            }
            else
            {
                print("Cheater");
            }
           
        }
    }
}
