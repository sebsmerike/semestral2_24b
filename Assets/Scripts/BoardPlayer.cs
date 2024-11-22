using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPlayer : Board
{
    public int posX, posY;

    void initBoard()
    {
        base.initBoard();

        // calcular center
        posX = 3;
        posY = 0;

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
