using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSavedData : MonoBehaviour
{

    public Text coinsText;

    void Start()
    {
        if(!PlayerPrefs.HasKey("CoinsTotal"))
        {
            PlayerPrefs.SetInt("CoinsTotal", 0);
        }

        coinsText.text = "Coins: " + PlayerPrefs.GetInt("CoinsTotal").ToString();
    }

}
