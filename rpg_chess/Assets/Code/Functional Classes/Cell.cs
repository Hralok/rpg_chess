using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{
    public Vector2Int coords { get; private set; }
    public CellTypeEnum type { get; private set; }
    public Unit unitAtCell { get; private set; }
    public Structure structureAtCell { get; private set; }
    public HashSet<Resource> resourcesAtCell { get; private set; }
    public Item itemAtCell { get; private set; }

    public Cell(Vector2Int coords, CellTypeEnum type)
    {
        this.coords = coords;
        this.type = type;
        unitAtCell = null;
        structureAtCell = null;
        itemAtCell = null;
        resourcesAtCell = new HashSet<Resource>();
    }

    public Unit ExpelUnit()
    {
        var expeledUnit = unitAtCell;
        unitAtCell = null;
        return expeledUnit;
    }

    public Structure ExpelStructure()
    {
        var expeledStructure = structureAtCell;
        structureAtCell = null;
        return expeledStructure;
    }

    public HashSet<Resource> ExpelResources()
    {
        var expeledResources = resourcesAtCell;
        resourcesAtCell = new HashSet<Resource>();
        return expeledResources;
    }

    public Item ExpelItem()
    {
        var expeledItem = itemAtCell;
        itemAtCell = null;
        return expeledItem;
    }

    public void AddResources(HashSet<Resource> newResources)
    {
        foreach (var resource in newResources)
        {
            if (!resourcesAtCell.Contains(resource))
            {
                resourcesAtCell.Add(resource);
            }
            else
            {
                foreach (var j in newResources)
                {
                    if (j.type == resource.type)
                    {
                        j.PutResource(resource.count);
                    }
                }
            }
        }
    }

    public void AddEntity(Entity entity)
    {
        switch (entity)
        {
            case Unit unit:
                unitAtCell = unit;
                break;
            case Structure structure:
                structureAtCell = structure;
                break;
        }
    }

    public void AddItem(Item item)
    {
        itemAtCell = item;
    }

    public void ChangeType(CellTypeEnum newType)
    {
        type = newType;
    }
}
