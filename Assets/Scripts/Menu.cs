using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;
    public GameObject shopPanel;
    public GameObject playerShopPanel;
    public GameObject groundShopPanel;
    public GameObject backgroundShopPanel;
    public GameObject aboutPanel;
    public GameObject exitPanel;

    public Text coinText;


    private int coin;

    private bool isOpen;

    void Awake()
    {
        Time.timeScale = 1f;

		mainMenuPanel.SetActive (true);
		optionsPanel.SetActive (false);
		shopPanel.SetActive (false);
		playerShopPanel.SetActive (false);
		groundShopPanel.SetActive (false);
		backgroundShopPanel.SetActive (false);
		aboutPanel.SetActive (false);
		exitPanel.SetActive (false);
    }

    void Start()
    {
        coin = GameMAnager.manager.CoinValue();
    }

    void Update()
    {
        coinText.text = "Coins: " + coin;
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Options()
    {
		mainMenuPanel.SetActive (false);
		optionsPanel.SetActive (true);
		shopPanel.SetActive (false);
		playerShopPanel.SetActive (false);
		groundShopPanel.SetActive (false);
		backgroundShopPanel.SetActive (false);
		aboutPanel.SetActive (false);
		exitPanel.SetActive (false);
    }

    public void Shop()
    {
		mainMenuPanel.SetActive (false);
		optionsPanel.SetActive (false);
		shopPanel.SetActive (true);
		playerShopPanel.SetActive (false);
		groundShopPanel.SetActive (false);
		backgroundShopPanel.SetActive (false);
		aboutPanel.SetActive (false);
		exitPanel.SetActive (false);
    }

    public void PlayerShop()
    {
		mainMenuPanel.SetActive (false);
		optionsPanel.SetActive (false);
		shopPanel.SetActive (false);
		playerShopPanel.SetActive (true);
		groundShopPanel.SetActive (false);
		backgroundShopPanel.SetActive (false);
		aboutPanel.SetActive (false);
		exitPanel.SetActive (false);
    }

    public void GroundShop()
    {
		mainMenuPanel.SetActive (false);
		optionsPanel.SetActive (false);
		shopPanel.SetActive (false);
		playerShopPanel.SetActive (false);
		groundShopPanel.SetActive (true);
		backgroundShopPanel.SetActive (false);
		aboutPanel.SetActive (false);
		exitPanel.SetActive (false);
    }

    public void BackgroundShop()
    {
		mainMenuPanel.SetActive (true);
		optionsPanel.SetActive (false);
		shopPanel.SetActive (false);
		playerShopPanel.SetActive (false);
		groundShopPanel.SetActive (false);
		backgroundShopPanel.SetActive (true);
		aboutPanel.SetActive (false);
		exitPanel.SetActive (false);
    }

    public void About()
    {
		mainMenuPanel.SetActive (false);
		optionsPanel.SetActive (false);
		shopPanel.SetActive (false);
		playerShopPanel.SetActive (false);
		groundShopPanel.SetActive (false);
		backgroundShopPanel.SetActive (false);
		aboutPanel.SetActive (true);
		exitPanel.SetActive (false);
    }

    public void Exit()
    {
		mainMenuPanel.SetActive (false);
		optionsPanel.SetActive (false);
		shopPanel.SetActive (false);
		playerShopPanel.SetActive (false);
		groundShopPanel.SetActive (false);
		backgroundShopPanel.SetActive (false);
		aboutPanel.SetActive (false);
		exitPanel.SetActive (true);
    }

    public void OptionsBack()
    {
		mainMenuPanel.SetActive (true);
		optionsPanel.SetActive (false);
		shopPanel.SetActive (false);
		playerShopPanel.SetActive (false);
		groundShopPanel.SetActive (false);
		backgroundShopPanel.SetActive (false);
		aboutPanel.SetActive (false);
		exitPanel.SetActive (false);
    }

    public void ShopBack()
    {
		mainMenuPanel.SetActive (true);
		optionsPanel.SetActive (false);
		shopPanel.SetActive (false);
		playerShopPanel.SetActive (false);
		groundShopPanel.SetActive (false);
		backgroundShopPanel.SetActive (false);
		aboutPanel.SetActive (false);
		exitPanel.SetActive (false);
    }

    public void PlayerBack()
    {
		mainMenuPanel.SetActive (false);
		optionsPanel.SetActive (false);
		shopPanel.SetActive (true);
		playerShopPanel.SetActive (false);
		groundShopPanel.SetActive (false);
		backgroundShopPanel.SetActive (false);
		aboutPanel.SetActive (false);
		exitPanel.SetActive (false);
    }

    public void GroundBack()
    {
		mainMenuPanel.SetActive (false);
		optionsPanel.SetActive (false);
		shopPanel.SetActive (true);
		playerShopPanel.SetActive (false);
		groundShopPanel.SetActive (false);
		backgroundShopPanel.SetActive (false);
		aboutPanel.SetActive (false);
		exitPanel.SetActive (false);
    }

    public void BackgroundBack()
    {
		mainMenuPanel.SetActive (false);
		optionsPanel.SetActive (false);
		shopPanel.SetActive (true);
		playerShopPanel.SetActive (false);
		groundShopPanel.SetActive (false);
		backgroundShopPanel.SetActive (false);
		aboutPanel.SetActive (false);
		exitPanel.SetActive (false);
    }

    public void AboutBack()
    {
		mainMenuPanel.SetActive (true);
		optionsPanel.SetActive (false);
		shopPanel.SetActive (false);
		playerShopPanel.SetActive (false);
		groundShopPanel.SetActive (false);
		backgroundShopPanel.SetActive (false);
		aboutPanel.SetActive (false);
		exitPanel.SetActive (false);
    }

    public void ExitNo()
    {
		mainMenuPanel.SetActive (true);
		optionsPanel.SetActive (false);
		shopPanel.SetActive (false);
		playerShopPanel.SetActive (false);
		groundShopPanel.SetActive (false);
		backgroundShopPanel.SetActive (false);
		aboutPanel.SetActive (false);
		exitPanel.SetActive (false);
    }

    public void ExitYes()
    {
        Application.Quit();
    }
}
