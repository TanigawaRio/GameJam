using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public static float TotalTime = 120;
    int Seconds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TotalTime > 0)
        {
            TotalTime -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("GameOver");
            TotalTime = 60;
        }

        int t = Mathf.FloorToInt(TotalTime);
        Text text = GetComponent<Text>();
        text.text = t + "•b";
    }
}
