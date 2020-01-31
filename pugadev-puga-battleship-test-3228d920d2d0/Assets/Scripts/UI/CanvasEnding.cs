using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasEnding : MonoBehaviour
{
    public Text endingMessage;
    public Text coinsNumber;

    private void Start()
    {
        if (GameManager.Instance.playerWon)
        {
            endingMessage.text = "WON";
            coinsNumber.text = "Coins: " + GameManager.Instance.currentPlayerCoins.ToString();
        }
        else
        {
            endingMessage.text = "GAME OVER";
        }
    }
}
