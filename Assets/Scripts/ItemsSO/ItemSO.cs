using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class ItemSO : ScriptableObject
{
    public string NameItem;
    public string Discription;
    public Sprite spriteItem;
    public abstract ItemSO GetTypeItem();

    public abstract TypeItem GetTypeEnum();
}

public enum TypeItem 
{
    Food = 1,
    UsedItem = 2,
    NotUsedItem = 3
}