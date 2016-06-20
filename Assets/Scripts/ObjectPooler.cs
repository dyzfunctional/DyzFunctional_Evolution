﻿using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ObjectPooler : MonoBehaviour
{

    public GameObject pooledObject;

    public int pooledAmt;

    List<GameObject> pooledObjects;

	// Use this for initialization
	void Start ()
    {
        pooledObjects = new List<GameObject>();

        for(int i = 0; i < pooledAmt; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);

            pooledObjects.Add(obj);
        }
	}

    public GameObject GetPooledObj()
    { 
        for(int i = 0; i < pooledObjects.Count; i++)
        {
            if(!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        GameObject obj = (GameObject)Instantiate(pooledObject);
        obj.SetActive(false);

        pooledObjects.Add(obj);

        return obj;
    }
}