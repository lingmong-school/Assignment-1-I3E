using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
* Author:Rayn Bin Kamaludin
* Date:15/5/2024
* Description: Script to be placed on the winning condition
*/

public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0, Time.time * 100f, 0);
    }

    void OnTriggerEnter(Collider other) // Load win sreen
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
