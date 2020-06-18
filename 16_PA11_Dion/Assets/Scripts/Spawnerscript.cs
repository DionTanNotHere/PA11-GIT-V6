﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public static Spawnerscript thisSpawner;
    public GameObject [] SpawnObject;
    int randomint;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
        
    }

    // Update is called once per frame
    void Update()
    {

        randomint = Random.Range(0, 3);
    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);

        Instantiate(SpawnObject[randomint],transform.position, transform.rotation);
    }

}