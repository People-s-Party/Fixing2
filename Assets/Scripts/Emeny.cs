using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emeny : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
    }
    void Update()
    {

    }
}
