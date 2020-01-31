﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasUI : MonoBehaviour
{
    public Text playerHealth;
    public Text playerCoins;

    // Update is called once per frame
    void Update()
    {
        playerHealth.text = "Health: " + GameManager.Instance.currentPlayerHealth.ToString();
        playerCoins.text = "Coins: " + GameManager.Instance.currentPlayerCoins.ToString();
    }
}
