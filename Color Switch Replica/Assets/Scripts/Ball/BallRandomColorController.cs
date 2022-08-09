using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRandomColorController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer ballSpriteRenderer;
    [SerializeField] private Color colorCyan;
    [SerializeField] private Color colorYellow;
    [SerializeField] private Color colorPink;
    [SerializeField] private Color colorPurple;

    public string availableColor;


    void Start()
    {
        SetBallColor();
    }



    public void SetBallColor()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0:
                ballSpriteRenderer.color = colorCyan;
                availableColor = "Cyan";
                break;
            case 1:
                ballSpriteRenderer.color = colorYellow;
                availableColor = "Yellow";
                break;
            case 2:
                ballSpriteRenderer.color = colorPink;
                availableColor = "Pink";
                break;
            case 3:
                ballSpriteRenderer.color = colorPurple;
                availableColor = "Purple";
                break;
        }

    }


}
