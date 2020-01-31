using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasEnding : MonoBehaviour
{

    public Text endingMessage;

    private void Start()
    {
        if (GameManager.Instance.playerWon)
        {
            endingMessage.text = "WON";
        }
        else
        {
            endingMessage.text = "GAME OVER";
        }
    }
}
