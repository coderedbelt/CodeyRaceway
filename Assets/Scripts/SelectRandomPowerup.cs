using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    public int powerup = 0;
    public GameObject shell;

  void Update()
    //it needs to be a conditional statement causing codey to 
    //decide wheter or not to spawn the powerup at his position
    {
       if(powerup == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(chosenPowerup, transform.position + Vector3.forward + Vector3.up, transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "itemBoxes")
        {
            randomNumberInList = Random.Range (0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
            powerup = 1;
        }
    }
}
