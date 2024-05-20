using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
* Author:Rayn Bin Kamaludin
* Date:18/5/2024
* Description: Win screen after the player wins
*/

public class Replay : MonoBehaviour
{
    //When the player just wins
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }


    //When game is restarted
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
