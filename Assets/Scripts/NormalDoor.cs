using System.Diagnostics; // Add this to use Stopwatch
using UnityEngine;

/*
* Author:Rayn Bin Kamaludin
* Date:17/5/2024
* Description: The normal door opening and closing
*/

public class NormalDoor : MonoBehaviour, PickUp
{
    private bool isOpen = false;
    private Stopwatch stopwatch = new Stopwatch();

    public void OpenDoor() //Open the door
    {
        if (!isOpen)
        {
            Vector3 currentRotation = transform.eulerAngles;
            currentRotation.y -= 90;
            transform.eulerAngles = currentRotation;
            isOpen = true;

            // Start the stopwatch when the door opens
            stopwatch.Restart();
        }
    }

    public void CloseDoor() // Close the door
    {
        if (isOpen)
        {
            Vector3 currentRotation = transform.eulerAngles;
            currentRotation.y += 90;
            transform.eulerAngles = currentRotation;
            isOpen = false;

            // Stop the stopwatch when the door closes
            stopwatch.Stop();
        }
    }

    private void Update()
    {
        // Check if the door is open and 1.5 seconds have passed
        if (isOpen && stopwatch.Elapsed.TotalSeconds >= 1.5)
        {
            CloseDoor();
        }
    }

    private void OnTriggerEnter(Collider other) // Make sure the player does not get stuck when the door closes
    {
        if (other.CompareTag("Player"))
        {
            OpenDoor();
        }
    }


    public void Interact() // Uses interact system to click E to open the door
    {
        if (isOpen)
            CloseDoor();
        else
            OpenDoor();
    }
}
