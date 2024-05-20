using System;
using UnityEngine;
/*
* Author:Rayn Bin Kamaludin
* Date:12/5/2024
* Description: Main obstacle which simply deducts points (used on the sea or lava falls)
*/

public class PointDeduction : MonoBehaviour
{
    public static event Action OnHurt;
    public static int hurt;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Invoke the OnHurt event
            OnHurt?.Invoke();
        }
    }
}
