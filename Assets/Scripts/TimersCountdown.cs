using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimersCountdown : MonoBehaviour
{
    public CodeyMove codeyMove;
    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;
    
    // Update is called once per frame
    void Update()
    {
        
       
       

        if (totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            codeyMove.Speed = 0;
        }
        if (totalCountdownTime <= 0)
        {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();

            codeyMove.Speed = 500;
        }

        if (totalLapTime < 0)
        {
            SceneManager.LoadScene("Lost");
        }
    }
}
