using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : Entity
{
public Dictionary<MainCharacteristicTypeEnum, double> mainChars { get; private set; }
    public Unit (Cell cell)
    {
        currentCell = cell;
    }

    public void ReplaceTheItemWith(Item replaceableItem, Item replacementItem)
    {
        
    }
}
