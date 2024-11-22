using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    BoardPlayer board;

    void Awake () {
        board = new BoardPlayer ();
        
        Debug.Log(board.posX + " " + board.getSize());
        Debug.Log(board.ToString());
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(board.posX + " " + board.getSize());
            Debug.Log(board.ToString());
        }
    }
}
