using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;

    public CodeyMove cm;
    public float totalLapTime;
    public float totalCountdownTime;
    
    void Start()
    {
        cm = GameObject.Find("Codey").GetComponent<CodeyMove>();
    }

    // Update is called once per frame
    void Update()
    {
        /*totalLapTime -= Time.deltaTime;
        totalCountdownTime -= Time.deltaTime;

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
        */
        if(totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
           startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            cm.Speed = 0f;
        }
        if(totalCountdownTime <= 0)
        {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            cm.Speed = 2500f;
            if (totalLapTime < 0)
            {
                print("Time is Up");

            }
        }
    }
}
