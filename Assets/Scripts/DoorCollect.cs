using System.Collections;
using System;
using TMPro;
using System.Collections.Generic;
using UnityEngine;
/*
* Author:Rayn Bin Kamaludin
* Date:12/5/2024
* Description: Door pieces tabulation and updating UI
*/

public class DoorCollect : MonoBehaviour
{
    // Static property to check if all pieces are collected
    public static bool AllPiecesCollected { get; private set; } = false;


    TMP_Text text;
    int piece;
    public bool PiecesCollected = false;

    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        InteractableObject.DoorCollected += AddPiece;
        UpdatePiece();
    }

    void AddPiece() // One piece has been found
    {
        piece += 1;
        UpdatePiece();

    }

    void UpdatePiece() //Update the UI based on current calues
    {
        // Ensure points do not go below 0
        piece = Mathf.Max(0, piece);
        text.text = $"{piece} / 5 Door Pieces Collected";

        if (piece == 5)
        {
            text.color = Color.yellow;
            AllPiecesCollected = true; 
        }

    }

}
