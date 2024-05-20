using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
* Author:Rayn Bin Kamaludin
* Date:16/5/2024
* Description: Script to move the sea rocks
*/
public class SeaRocks : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0, Time.time * 50f, 0);

    }

    
}
