using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public abstract TypeItem GetTypeEnumItem();
    public abstract ItemSO GetTypeItem();
}
