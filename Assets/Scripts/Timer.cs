using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    float levelTimer = 0f;

    // Update is called once per frame
    void Update()
    {
        levelTimer += Time.deltaTime;
        timerText.text = levelTimer.ToString("F0");
    }
}
