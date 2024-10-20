using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FoodItem", menuName = "ItemsSO/Food")]
public class FoodItemSO : ItemSO
{
    public override ItemSO GetTypeItem()
    {
        return this;
    }

    public override TypeItem GetTypeEnum() 
    {
        return TypeItem.Food;
    }
}
