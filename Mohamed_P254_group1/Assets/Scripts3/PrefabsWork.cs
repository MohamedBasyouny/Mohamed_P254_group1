﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabsWork : MonoBehaviour
{
    public GameObject sphereObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(sphereObject, transform.position, Quaternion.identity);
        }
    }
}
