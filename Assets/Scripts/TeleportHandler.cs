using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/*
* Author:Rayn Bin Kamaludin
* Date:18/5/2024
* Description: Teleport the player to the correct cave checkpoit
*/

public class TeleportHandler : MonoBehaviour
{
    // Teleport player to the right entrance
    public Vector3 teleportBarPosition = new Vector3(-168f, 2f, -2.58f);
    public Vector3 teleportBeachPosition = new Vector3(-192.06f, -6.11f, 36.77f);

    void OnEnable()
    {
        LavaCave.OnBarTeleport += HandleBarTeleport;
        LavaCave1.OnBeachTeleport += HandleBeachTeleport;
    }

    void OnDisable()
    {
        LavaCave.OnBarTeleport -= HandleBarTeleport;
        LavaCave1.OnBeachTeleport -= HandleBeachTeleport;
    }

    private void HandleBarTeleport()
    {
        transform.position = teleportBarPosition;
        Debug.Log("Player teleported to: " + teleportBarPosition);
    }

    private void HandleBeachTeleport()
    {
        transform.position = teleportBeachPosition;
        Debug.Log("Player teleported to: " + teleportBeachPosition);
    }
}
