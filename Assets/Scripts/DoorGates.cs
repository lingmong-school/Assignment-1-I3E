using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/*
* Author:Rayn Bin Kamaludin
* Date:14/5/2024
* Description: Main gate opening script
*/


public class DoorGates : MonoBehaviour
{
    public float speed = 1;
    public float smoothTime = 0.5f;
    public Vector3 target = new Vector3(0f, 7.23f, 0f);
    private Vector3 currentVelocity;
    private bool shouldMove = false;

    void Awake()
    {
        DoorOpen.DoorOpened += OnGateOpened;
    }

    void OnDestroy()
    {
        DoorOpen.DoorOpened -= OnGateOpened;
    }

    void Update()
    {
        if (shouldMove)
        {
            transform.position = Vector3.SmoothDamp(transform.position, target, ref currentVelocity, smoothTime);
        }
    }

    private void OnGateOpened()
    {
        Debug.Log("Gate opening...");
        shouldMove = true;
    }
}
