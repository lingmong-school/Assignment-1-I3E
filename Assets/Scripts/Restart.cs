using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
* Author:Rayn Bin Kamaludin
* Date:17/5/2024
* Description: Lose screen for when the player loses
*/
public class Restart : MonoBehaviour
{
    //When the player just loses
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }


    //When game is restarted
    public void ReplayGame()
    {
        SceneManager.LoadScene(0);
    }

}
