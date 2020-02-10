﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTarget2Nega : MonoBehaviour
{
    public int velocidad = 0;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(startPos.x + (Mathf.Sin(Time.time * velocidad)) * -3, startPos.y, startPos.z);
    }


}
