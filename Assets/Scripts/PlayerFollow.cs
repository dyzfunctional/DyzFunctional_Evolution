using UnityEngine;
using System.Collections;

public class PlayerFollow : MonoBehaviour
{
    public PlayerManager thePlayer;

    private Vector3 lastPlayerPos;

    private float movePlayerX;
    private float movePlayerY;

    // Use this for initialization
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerManager>();

        lastPlayerPos = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movePlayerX = thePlayer.transform.position.x - lastPlayerPos.x;
        movePlayerY = thePlayer.transform.position.y - lastPlayerPos.y;

        transform.position = new Vector3(transform.position.x + movePlayerX, transform.position.y + movePlayerY, transform.position.z);

        lastPlayerPos = thePlayer.transform.position;
    }
}