using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/*
* Author:Rayn Bin Kamaludin
* Date:13/5/2024
* Description: Make the door parts appear on the door
*/

public class DoorPartsAppear : MonoBehaviour
{
    void Awake()
    {
        // Initially deactivate the object
        gameObject.SetActive(false);

        // Subscribe to the DoorOpened event
        DoorOpen.DoorOpened += OnDoorOpened;
    }

    void OnDestroy()
    {
        DoorOpen.DoorOpened -= OnDoorOpened;
    }

    private void OnDoorOpened()
    {
        // Activate the object
        gameObject.SetActive(true);
    }
}
