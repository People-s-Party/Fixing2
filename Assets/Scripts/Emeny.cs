﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emeny : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(moveTotal);

    }
}
