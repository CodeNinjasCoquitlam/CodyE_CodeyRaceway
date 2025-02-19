using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimersCountdown : MonoBehaviour
{
    public CodeyMove movement;

    public Text lapTimer;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTimer;

    // Start is called before the first frame update
    void Start()
    {
        movement.Speed = 0;
        lapTimer.text = "";
        totalLapTime = 500;
        totalCountdownTimer = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (totalCountdownTimer > 0)
        {
            totalCountdownTimer -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTimer).ToString();
        }
        if(totalCountdownTimer < 1)
        {
            movement.Speed = 300;
            totalLapTime -= Time.deltaTime;
            startCountdown.text = "";
            lapTimer.text = Mathf.Round(totalLapTime).ToString();
            Debug.Log("Time Is Up");
        }
        if (totalLapTime < 1)
        {
            SceneManager.LoadScene("Lost");
        }
    }
}
