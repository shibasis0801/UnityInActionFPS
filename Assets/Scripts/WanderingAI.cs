﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    public float speed = 3.0f;

    public float obstacleRange = 5.0f;

    private bool isAlive = true;

    public void setAlive(bool isAlive)
    {
        this.isAlive = isAlive;
    }
    
    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.SphereCast(ray, 0.75f, out hit))
            {
                if (hit.distance < obstacleRange)
                {
                    float yaw = Random.Range(-110, 110);
                    transform.Rotate(0, yaw, 0);
                }
            }
        }
    }
}
