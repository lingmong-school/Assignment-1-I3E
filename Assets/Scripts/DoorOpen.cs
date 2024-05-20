using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/*
* Author:Rayn Bin Kamaludin
* Date:13/5/2024
* Description: Door checking if all door pieces are accounted for
*/

public class DoorOpen : MonoBehaviour, PickUp
{
    public static event Action DoorOpened;

    public void Interact()
    {
        if (DoorCollect.AllPiecesCollected)
        {
            Debug.Log("Door activated");
            DoorOpened?.Invoke();
            // Door has been activated
        }
        else
        {
            Debug.Log("You need to collect all pieces first.");
        }
    }
}