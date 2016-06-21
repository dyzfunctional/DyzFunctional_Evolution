using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GUIManager : MonoBehaviour
{
    public PlayerManager player;

    public GameObject restartPanel;
	public GameObject pausePanel;

    //coin Text Variables
    public Text coinText;

    //HighScore Text Variable
    public Text highScore;

    //dIstance Text variable
    public Text distance;

    public bool death;

    private float distanceRan = 0;
    private int coin;
    private float highScores;

	// Use this for initialization
	void Start ()
    {
        player = FindObjectOfType<PlayerManager>();

        coin = 0;

        highScores = GameMAnager.manager.highScore;

        restartPanel.SetActive(false);
		pausePanel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        distanceRan = player.transform.position.x;

        coinText.text = "Coins: " + coin;
        highScore.text = "High Score: " + Mathf.Round(highScores);
        distance.text = " " + Mathf.Round(distanceRan);

        if(death)
        {
            restartPanel.SetActive(true);
        }
	}

    public void AddCoin(int coinsToAdd)
    {
        if (GameMAnager.manager.DoubleCoins)
        {
            coin = coin + (coinsToAdd * 2);
        }
        else
        {
            coin += coinsToAdd;
        }
    }

    public void RestartYes()
    {
		SaveData ();

        SceneManager.LoadScene(1);
    }

    public void RestartNo()
    {
		SaveData ();

        SceneManager.LoadScene(0);
    }

	void SaveData()
	{
		GameMAnager.manager.coins = GameMAnager.manager.coins + coin;

		if(GameMAnager.manager.highScore < distanceRan)
		{
			GameMAnager.manager.highScore = distanceRan;
		}

		GameMAnager.manager.Save();
	}

	public void PauseGame()
	{
		Time.timeScale = 0f;
		pausePanel.SetActive(true);
	}

	public void UnPauseGame()
	{
		Time.timeScale = 1f;
		pausePanel.SetActive (false);
	}
}