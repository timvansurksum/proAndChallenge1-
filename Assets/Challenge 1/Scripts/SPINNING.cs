﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPINNING : MonoBehaviour
{
    public float turnSpeed = 25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * 50);
    }
}
