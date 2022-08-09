using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotateController : MonoBehaviour
{

    [SerializeField] private float rotateSpeed;
    [SerializeField] private bool circleDirection;



    void Update()
    {
        SetCircleRotate();
    }



    private void SetCircleRotate()
    {
        if (circleDirection == false)
        {
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        }

        else
        {
            transform.Rotate(0, 0, -1 * rotateSpeed * Time.deltaTime);
        }

    }
}
