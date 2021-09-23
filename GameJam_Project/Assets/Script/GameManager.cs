using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject OnLoad;

    public static GameObject Singleton;

    public void Awake()
    {
        if(SceneManager.GetActiveScene().name != "GameOver")
        {
            if (Singleton == null)
            {
                DontDestroyOnLoad(OnLoad);
                Singleton = OnLoad;
            }
            else
            {
                Destroy(OnLoad);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 120;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(string NextScene)
    {
        SceneManager.LoadScene(NextScene);
    }

    public void Rotation(GameObject RotateObject)
    {
        RotateObject.GetComponent<SmartPhone>().RotationFlag = true;
    }
}
