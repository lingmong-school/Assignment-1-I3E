using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public float newMoveSpeed = 6.0f;
    public float newSprintSpeed = 12.0f;
    public float newJumpHeight = 2.0f;

    private FirstPersonController firstPersonController;

    void Start()
    {
        // Access the FirstPersonController component
        firstPersonController = GetComponent<FirstPersonController>();

        // Check if the component is found
        if (firstPersonController != null)
        {
            
        }
        else
        {
            Debug.LogError("FirstPersonController component not found on the player object.");
        }
    }
}
