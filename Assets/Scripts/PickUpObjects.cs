using UnityEngine;
using System.Collections;

public class PickUpObjects : MonoBehaviour
{
    public int scoreToGive;

    private GUIManager GUI;

	// Use this for initialization
	void Start ()
    {
        GUI = FindObjectOfType<GUIManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GUI.AddCoin(scoreToGive);
            gameObject.SetActive(false);
        }
    }
}