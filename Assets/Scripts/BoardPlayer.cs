using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPlayer : Board
{
    public int posX, posY;

    public BoardPlayer() : base()
    {
        // calcular center
        posY = Mathf.FloorToInt(size / 2f);
        posX = 0;

        tablero[posX, posY] = 2;

    }

    public void moveLeft()
    {
        if(canMoveLeft())
            posX--;
    }
    public bool canMoveLeft()
    {
        if (posX == 0)
            return false;
        else
            return true;
    }
}
