using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    Board tablero;

    void Awake()
    {
        tablero = new Board();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            tablero.resetBoard();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log(tablero.ToString());
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            tablero.randomBoard();
        }
    }
}
