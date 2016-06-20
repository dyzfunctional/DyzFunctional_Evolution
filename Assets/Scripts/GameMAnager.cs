using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

public class GameMAnager : MonoBehaviour
{
    public static GameMAnager manager;


    //player variables
    public int coins;
    public float highScore;

    //bool to see if first time playing
    public bool firstTime = true;

	// Use this for initialization
	void Awake ()
    {
        Load();

        if(firstTime)
        {
            coins = 0;
            highScore = 0;
            firstTime = false;

            Save();
        }
        if(manager == null)
        {
            DontDestroyOnLoad(gameObject);
            manager = this;
        }
        if(!manager)
        {
            Destroy(gameObject);
        }
	}

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/PlayerData.dat");

        PlayerData data = new PlayerData();

        data.coinsIHave = coins;
        data.highScore = highScore;
        data.firstTime = firstTime;

        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/PlayerData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/PlayerData.dat", FileMode.Open);

            PlayerData data = (PlayerData)bf.Deserialize(file);

            file.Close();

            coins = data.coinsIHave;
            highScore = data.highScore;
            firstTime = data.firstTime;
        }
    }

    public int CoinValue()
    {
        return coins;
    }
}

[Serializable]
class PlayerData
{
    //public variables
    public int coinsIHave;
    public float highScore;
    public bool firstTime;
}