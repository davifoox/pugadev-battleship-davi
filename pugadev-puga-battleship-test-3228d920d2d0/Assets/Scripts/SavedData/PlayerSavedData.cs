using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSavedData : MonoBehaviour
{

    public Text coinsText;
    public Text playerLevelText;


    void Start()
    {
        if(!PlayerPrefs.HasKey("CoinsTotal"))
        {
            PlayerPrefs.SetInt("CoinsTotal", 0);
        }

        coinsText.text = "Coins: " + PlayerPrefs.GetInt("CoinsTotal").ToString();

        if (!PlayerPrefs.HasKey("PlayerLevel"))
        {
            PlayerPrefs.SetInt("PlayerLevel", 5);
        }

        playerLevelText.text = playerLevelText.text = "Player Level: " + PlayerPrefs.GetInt("PlayerLevel").ToString();
    }

    public void IncreasePlayerLevelButton()
    {
        if (PlayerPrefs.GetInt("PlayerLevel") < 5)
        {
            PlayerPrefs.SetInt("PlayerLevel", PlayerPrefs.GetInt("PlayerLevel") + 1);
            playerLevelText.text = "Player Level: " + PlayerPrefs.GetInt("PlayerLevel").ToString();
        }
    }
    public void DecreasePlayerLevelButton()
    {
        if (PlayerPrefs.GetInt("PlayerLevel") > 1)
        {
            PlayerPrefs.SetInt("PlayerLevel", PlayerPrefs.GetInt("PlayerLevel") - 1);
            playerLevelText.text = "Player Level: " + PlayerPrefs.GetInt("PlayerLevel").ToString();
        }
    }
}
