using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsManager : MonoBehaviour
{
    public void StartGameButton() {SceneManager.LoadScene(1);}

    public void PlayAgainButton() {SceneManager.LoadScene(1);}

    public void BackToMenuButton() {SceneManager.LoadScene(0);}
}
