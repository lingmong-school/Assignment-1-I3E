using System;
using UnityEngine;

public class LavaCave : MonoBehaviour
/*
* Author:Rayn Bin Kamaludin
* Date:17/5/2024
* Description: Point deduction and teleportation of the left side of the cave
*/

{
    public static event Action OnHurt; // Responsible for point deduction
    public static event Action OnBarTeleport; // Responsible for Teleporting to the bar
    public static int hurt;

    void OnTriggerEnter(Collider other) // When player touches the lava
    {
        if (other.CompareTag("Player"))
        {
          
            OnHurt?.Invoke();
            OnBarTeleport?.Invoke();
            
        }
    }
}
