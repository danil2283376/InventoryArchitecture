using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsedItem : Item
{
    public UsedItemSO UsedItemSO; 

    public override TypeItem GetTypeEnumItem()
    {
        return UsedItemSO.GetTypeEnum();
    }

    public override ItemSO GetTypeItem()
    {
        return UsedItemSO.GetTypeItem();
    }
}
