using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class End : MonoBehaviour
{
    public GameObject exit;
    public Transform[] pos;

    public static End instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Position();
    }



    public void Position()
    {
        int rand = Random.Range(0, 7);
        exit.transform.position = pos[rand].position;
    }
}
