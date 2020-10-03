using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IdleTimeOut : MonoBehaviour
{
    int IdleTimeSetting = 5;
    float LastIdleTime;

    void Awake()
    {

        LastIdleTime = Time.time;
    }

    private void Update()
    {

        if (Input.anyKey)
        {
            LastIdleTime = Time.time;
        }
    
        if (Time.time - LastIdleTime > IdleTimeSetting)
        {
            SceneManager.LoadScene("SplashScene");
        }
    }
}
