using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] private TMP_Text timer;
    [SerializeField] private TMP_Text ballSpeed;

    private void Update()
    {
        if (GameManager.instance.remainingTime > 0)
        {
            int minutes = Mathf.FloorToInt(GameManager.instance.remainingTime / 60);
            int seconds = Mathf.FloorToInt(GameManager.instance.remainingTime % 60);

            timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        int flooredBallSpeed = Mathf.FloorToInt(GameManager.instance.ballSpeed);
        ballSpeed.text = string.Format("Ball Speed: {0}", flooredBallSpeed);
    }
}
