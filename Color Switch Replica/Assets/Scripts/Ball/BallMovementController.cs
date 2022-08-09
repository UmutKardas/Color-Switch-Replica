using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    [SerializeField] private BallDataTransmitter ballDataTransmitter;
    [SerializeField] private Rigidbody2D ballRigidbody2D;
    [SerializeField] private float ballJumpSpeed;


    void FixedUpdate()
    {
        SetBallMovement();
    }



    private void SetBallMovement()
    {
        if (ballDataTransmitter.GetMouseTouchController() == true)
        {
            ballRigidbody2D.velocity = Vector3.up * ballJumpSpeed * Time.fixedDeltaTime;
        }
    }
}
