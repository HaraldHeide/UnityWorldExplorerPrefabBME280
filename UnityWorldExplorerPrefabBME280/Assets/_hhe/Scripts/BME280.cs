﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BME280 : MonoBehaviour
{
    [SerializeField]
    GameObject myPrefab;
    private void Awake()
    {
        
    }
    void Start ()
    {
        float temperature = 23.5f;
        float humidity = 67.5f;
        float pressure = 100200.5f;
        myPrefab.GetComponentInChildren<TextMesh>().text = $"Temperature: {temperature}\nHumidity: {humidity}\nPressure: {pressure} ";
	}
	
	// Update is called once per frame
	void Update ()
    {
	}
}