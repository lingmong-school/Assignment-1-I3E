using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
/*
* Author:Rayn Bin Kamaludin
* Date:12/5/2024
* Description: Interactable doorpieces
*/

public class InteractableObject : MonoBehaviour, PickUp
{
    public static event Action DoorCollected;
    public static int piece;
    void Awake() => piece++;

    public void Interact() // When pieces are interacted upon
    {
        Debug.Log("Door Piece Collected");
        Destroy(gameObject);
        DoorCollected?.Invoke();
    }

}
