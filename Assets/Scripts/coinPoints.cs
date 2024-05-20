using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

/*
* Author:Rayn Bin Kamaludin
* Date:10/5/2024
* Description: Point tablutating system and updating the UI
*/


public class coinPoints : MonoBehaviour
{
    TMP_Text text;
    int count;

    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    void Start()
    {
        count += 10;
        // Subscribe to the OnCollected event for adding points
        coinCollect.OnCollected += AddPoints;
        // Subscribe to the OnHurt event for deducting points
        PointDeduction.OnHurt += DeductPoints;
        UpdateCount();
    }

    void OnDestroy()
    {
        // Unsubscribe from the events to prevent memory leaks
        coinCollect.OnCollected -= AddPoints;
        PointDeduction.OnHurt -= DeductPoints;
    }

    void AddPoints()
    {
        // Add 10 points when a coin is collected
        count += 10;
        UpdateCount();
    }

    void DeductPoints()
    {
        // Deduct 10 points when the cube is touched
        count -= 10;
        UpdateCount();
    }

    void UpdateCount()
    {
        // Ensure points do not go below 0
        count = Mathf.Max(0, count);
        text.text = $"{count} Points";

        // Check if points are 0 and the player has lost
        if (count == 0)
        {
            Debug.Log("Player lost");
            SceneManager.LoadScene(1);
           
        }
    }
}
