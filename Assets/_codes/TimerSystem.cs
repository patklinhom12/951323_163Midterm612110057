using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimerSystem : MonoBehaviour
{
    public static float timeStart = 120;
    public Text Textbox;
    // Start is called before the first frame update
    void Start()
    {
        Textbox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        Textbox.text = Mathf.Round(timeStart).ToString();
        if (timeStart <= 0)
        {
            TimeOutGameOver();
        }
    }

    public void TimeOutGameOver()
    {
        SceneManager.LoadScene("StageSelection");
    }
}
