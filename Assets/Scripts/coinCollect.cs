using System;
using UnityEngine;

/*
* Author:Rayn Bin Kamaludin
* Date:10/5/2024
* Description: Coin collecting script
*/

public class coinCollect : MonoBehaviour
{

    public static event Action OnCollected;
    public static int total;

    void Awake() => total++;

    // Update is called once per frame
    void Update()
    {
        //Make coin spin
        transform.localRotation = Quaternion.Euler(90f, Time.time * 100f, 0);
    }
    // Make coin dissappear
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }
}
