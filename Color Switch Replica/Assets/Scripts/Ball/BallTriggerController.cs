using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallTriggerController : MonoBehaviour
{

    [SerializeField] private BallDataTransmitter ballDataTransmitter;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (ballDataTransmitter.GetAvailableColor() != other.tag && !other.gameObject.CompareTag("ColorChanger"))
        {
            SceneManager.LoadScene(0);
        }


        if (other.CompareTag("ColorChanger"))
        {
            ballDataTransmitter.GetBallColor();
            other.gameObject.SetActive(false);

        }
    }
}
