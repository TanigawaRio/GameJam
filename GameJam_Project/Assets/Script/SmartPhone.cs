using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmartPhone : MonoBehaviour
{
    public bool RotationFlag = false;
    float RotationTime = 0;
    float RotationSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (RotationFlag == true)
        {
            transform.Rotate(0, 0, 1 * Time.deltaTime * RotationSpeed);

            RotationTime += 1 * Time.deltaTime * RotationSpeed;

            Quaternion quaternion = transform.rotation;

            if(RotationTime > 90)
            {
                transform.rotation = Quaternion.Euler(0, 0, (int)quaternion.eulerAngles.z);

                RotationFlag = false;
            }
        }
        else
        {
            RotationTime = 0;
        }
    }
}
