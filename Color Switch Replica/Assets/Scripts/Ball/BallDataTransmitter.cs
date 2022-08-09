using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmitter : MonoBehaviour
{
    [SerializeField] private BallInputController ballInputController;
    [SerializeField] private BallRandomColorController ballRandomColorController;


    public bool GetMouseTouchController()
    {
        return ballInputController.isTouch;
    }



    public string GetAvailableColor()
    {
        return ballRandomColorController.availableColor;
    }



    public void GetBallColor()
    {
        ballRandomColorController.SetBallColor();
    }

}
