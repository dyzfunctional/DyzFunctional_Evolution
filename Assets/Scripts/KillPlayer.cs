using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour
{
    public GUIManager GUI;

    public int num;

    void Start()
    {
        GUI = FindObjectOfType<GUIManager>();

    }

	void OnTriggerEnter(Collider other)
    {
        num = Random.Range(0, 100);

        if(other.gameObject.tag == "Player")
        {
            Time.timeScale = 0f;

            //display ad 20% of the time after player dies
            if (num < 30)
            {
                GameMAnager.manager.ShowAd();
            }

            GameMAnager.manager.DoubleCoins = false;

            GUI.death = true;
        }
    }
}
