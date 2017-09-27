using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse X") > 0)
        {
            GUIController.debugText = "Right";
        }

        if (Input.GetAxis("Mouse X") < 0)
        {
            GUIController.debugText = "Left";
        }
    }
}

