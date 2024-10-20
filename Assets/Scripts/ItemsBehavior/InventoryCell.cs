using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCell
{
    public Item Item;
    public int CountIdenticalObject = 0;

    public InventoryCell(Item item)
    {
        Item = item;
        CountIdenticalObject = 1;
    }

    public ItemSO GetItemType() 
    {
        return Item.GetTypeItem().GetTypeItem();
    }

    public TypeItem GetTypeEnumItem() 
    {
        return Item.GetTypeItem().GetTypeEnum();
    }

    public void AddDublicate() 
    {
        CountIdenticalObject++;
        Debug.Log(Item.GetTypeItem().NameItem + " кол-во в €чейке: " + CountIdenticalObject);
    }
}
