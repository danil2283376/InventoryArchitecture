using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotUsedItem : Item
{
    public NotUsedItemSO NotUsedItemSO;

    public override TypeItem GetTypeEnumItem()
    {
        return NotUsedItemSO.GetTypeEnum();
    }

    public override ItemSO GetTypeItem()
    {
        return NotUsedItemSO.GetTypeItem();
    }
}
