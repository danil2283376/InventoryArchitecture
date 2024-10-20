using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NotUsedItem", menuName = "ItemsSO/NotUsedItem")]
public class NotUsedItemSO : ItemSO
{
    public override ItemSO GetTypeItem()
    {
        return this;
    }

    public override TypeItem GetTypeEnum()
    {
        return TypeItem.NotUsedItem;
    }
}
