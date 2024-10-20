using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UsedItemSO", menuName = "ItemsSO/UsedItemSO")]
public class UsedItemSO : ItemSO
{
    public override ItemSO GetTypeItem()
    {
        return this;
    }

    public override TypeItem GetTypeEnum()
    {
        return TypeItem.UsedItem;
    }
}
