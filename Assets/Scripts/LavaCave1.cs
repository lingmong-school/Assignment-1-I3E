using System;
using UnityEngine;

/*
* Author:Rayn Bin Kamaludin
* Date:17/5/2024
* Description: Point deduction and teleportation of the Right side of the cave
*/

public class LavaCave1 : MonoBehaviour
{
    public static event Action OnHurt; // Responsible for point deduction
    public static event Action OnBeachTeleport; // Responsible for Teleporting to the beach
    public static int hurt;

    void OnTriggerEnter(Collider other) // When player toouches the lava
    {
        if (other.CompareTag("Player"))
        {
            
            OnHurt?.Invoke();
            OnBeachTeleport?.Invoke();
            
        }
    }
}
