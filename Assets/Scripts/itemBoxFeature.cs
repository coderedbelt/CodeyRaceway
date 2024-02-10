using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeature : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(transform.eulerAngles.x + 10, transform.eulerAngles.y + 7, transform.eulerAngles.z + 8), Time.deltaTime * 30f);

        if (!gameObject.activeSelf)
        {
            Invoke("itemBoxRespawn", 2f);
        }
    }

    public void itemBoxRespawn()
    {
        gameObject.SetActive(true);
        
    }
    
}