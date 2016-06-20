using UnityEngine;
using System.Collections;

public class DeactivateObject : MonoBehaviour
{

    public GameObject deactivatePoint;

	// Use this for initialization
	void Start ()
    {
        deactivatePoint = GameObject.Find("DeactivateObjects");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(transform.position.x < deactivatePoint.transform.position.x)
        {
            gameObject.SetActive(false);
        }
	}
}