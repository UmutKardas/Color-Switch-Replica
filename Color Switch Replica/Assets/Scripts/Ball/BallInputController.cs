using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInputController : MonoBehaviour
{
    public bool isTouch;


    void Update()
    {
        SetMouseTouchController();
    }



    private void SetMouseTouchController()
    {
        if (Input.GetMouseButton(0))
        {
            isTouch = true;
        }

        else
        {
            isTouch = false;
        }

    }
}
