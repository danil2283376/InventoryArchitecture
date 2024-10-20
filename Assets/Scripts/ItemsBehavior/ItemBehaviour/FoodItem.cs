using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class FoodItem : Item
{
    public FoodItemSO FoodItemSO;
    public override TypeItem GetTypeEnumItem()
    {
        return FoodItemSO.GetTypeEnum();
    }

    public override ItemSO GetTypeItem()
    {
        return FoodItemSO.GetTypeItem();
    }
}
