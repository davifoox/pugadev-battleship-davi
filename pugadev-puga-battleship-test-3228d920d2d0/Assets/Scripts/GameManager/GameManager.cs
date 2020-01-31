using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Singleton")]
    public static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    [Header("References")]
    public Transform pivotToRestart;
    public GameObject ship;

    [Header("Behaviour")]
    [HideInInspector] public float gameTime = 1;
    [HideInInspector] public bool endGame;


    [Header("PlayerState")]
    public int currentPlayerHealth;
    public int currentPlayerCoins;
    public float timerToEnd = 5;
    public bool playerWon;

    void Awake()
    {
        instance = this;
        DontDestroyOnLoad(instance.gameObject);
    }


    void Update()
    {
        if (Input.GetButton("Cancel") && endGame)
            RestartGame();

        if (!endGame)
        {
            timerToEnd -= Time.deltaTime;
            if (timerToEnd < 0) { timerToEnd = 0; }
        }
    }


    public void EndGame(bool won)
    {
        endGame = true;
        SpawnManager.Instance.spawnAble = false;
        gameTime = 0;

        if (won)
        {
            playerWon = true;
        }
        else
        {
            playerWon = false;
        }
        
        SceneManager.LoadScene(2);
    }


    void RestartGame()
    {
        endGame = false;
        ship.transform.position = new Vector3(pivotToRestart.position.x, ship.transform.position.y, pivotToRestart.position.z);
        ship.GetComponent<ShipController>().allStatus[ship.GetComponent<ShipController>().healthLevel - 1].health = 100;
        ship.GetComponent<ShipController>().EnebleMesh(true);
        SpawnManager.Instance.DestroyerAllEnemy();
        SpawnManager.Instance.spawnAble = true;
        gameTime = 1;
        timerToEnd = 5;
        SceneManager.LoadScene(1);
    }
}
