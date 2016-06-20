using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour
{
    public GUIManager GUI;

    void Start()
    {
        GUI = FindObjectOfType<GUIManager>();

    }
	void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Time.timeScale = 0f;
            GUI.death = true;
        }
    }
}
