using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public PlayerManager thePlayer;

    private Vector3 lastPlayerPos;

    private float moveCamera;

	// Use this for initialization
	void Start ()
    {
        thePlayer = FindObjectOfType<PlayerManager>();

        lastPlayerPos = thePlayer.transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        moveCamera = thePlayer.transform.position.x - lastPlayerPos.x;

        transform.position = new Vector3(transform.position.x + moveCamera, transform.position.y, transform.position.z);

        lastPlayerPos = thePlayer.transform.position;
	}
}