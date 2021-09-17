using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text TimerText;

    public float TotalTime;
    int Seconds;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime -= Time.deltaTime;
        Seconds = (int)TotalTime;
        TimerText.text = Seconds.ToString();
    }

    public void ChangeScene(string NextScene)
    {
        SceneManager.LoadScene(NextScene);
    }

    public void Rotation(string RotateObject)
    {
        transform.Rotate(0, 0, 90);

    }
}
