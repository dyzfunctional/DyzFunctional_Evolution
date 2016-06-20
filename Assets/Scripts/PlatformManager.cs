using UnityEngine;
using System.Collections;

public class PlatformManager : MonoBehaviour
{
    public PlayerManager player;

    public ObjectPooler[] pools;

    public Transform generationPoint;

    public float distanceBetween;
    public float distanceMin;
    public float distanceMax;

    public float heightChange;
    public float maxHeightChange;

    public Transform maxHeightPoint;

    private float[] platformWidths;

    public CoinGenerator coinGen;

    private int platformSelect;

    private float minHeight;
    private float maxHeight;

    // Use this for initialization
    void Start ()
    {
        coinGen = FindObjectOfType<CoinGenerator>();

        player = FindObjectOfType<PlayerManager>();

        platformWidths = new float[pools.Length];

        for (int i = 0; i < pools.Length; i++)
        {
            //get the platform length of the box collider
            platformWidths[i] = pools[i].pooledObject.GetComponentInChildren<BoxCollider>().size.x;
        }
        minHeight = transform.position.y;
        maxHeight = maxHeightPoint.position.y;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.x < generationPoint.transform.position.x)
        {
            distanceBetween = Random.Range(distanceMin, distanceMax);

            platformSelect = Random.Range(0, pools.Length);

            heightChange = transform.position.y + Random.Range(maxHeightChange, -maxHeightChange);

            if(heightChange > maxHeight)
            {
                heightChange = maxHeight;
            }
            else if(heightChange < minHeight)
            {
                heightChange = minHeight;
            }
        
            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelect] /2) + distanceBetween, heightChange, transform.position.z);

            GameObject newPlatform = pools[platformSelect].GetPooledObj();

            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);

            coinGen.SpawnCoins(new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z));

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelect] / 2), transform.position.y, transform.position.z);
        }
	}

    public void ChangeMinMax10()
    {
        distanceMin += 0.5f;
        distanceMax += 0.5f;
    }

    public void ChangeMinMax15()
    {
        distanceMin += 1f;
        distanceMax += 1f;
    }

    public void ChangeMinMax20()
    {
        distanceMin += 2f;
        distanceMax += 2f;
    }
}