using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmartPhone : MonoBehaviour
{
    public bool flag = false;

    float time = 0;

    float Speed = 20;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true)
        {
            transform.Rotate(0, 0, 1 * Time.deltaTime * Speed);

            time += 1 * Time.deltaTime * Speed;

            Quaternion quaternion = transform.rotation;

            if(time > 90)
            {
                transform.rotation = Quaternion.Euler(0, 0, (int)quaternion.eulerAngles.z);

                flag = false;
            }
        }
        else
        {
            time = 0;
        }
    }
}
