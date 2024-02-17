using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;

    void Update()
    //it needs to be a conditional statement causing codey to 
    //decide wheter or not to spawn the powerup at his position
    {
        if(){

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "itemBoxes")
        {
            randomNumberInList = Random.Range (0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }
}
