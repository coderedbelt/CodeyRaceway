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
    public GameObject gameOverCanvas;
    
    void Start()
    {
        cm = GameObject.Find("Codey").GetComponent<CodeyMove>();
        gameOverCanvas.SetActive(false);

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
            cm.canMove = false;
        }
        if(totalCountdownTime <= 0)
        {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            cm.canMove = true;
            
            if (totalLapTime < 0)
            {
                print("Time is Up");
                gameOverCanvas.SetActive(true);
                Time.timeScale = 0;

            }
        }
    }
}
