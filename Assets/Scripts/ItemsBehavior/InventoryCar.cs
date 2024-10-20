using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCar : MonoBehaviour
{
    public BoxCollider2D BoxColliderInventory;
    public Rigidbody2D RigidbodyInventory;

    private List<InventoryCell> inventoryCells = new List<InventoryCell>();

    public TypeErrorInventory AddItemInventory(Item item)
    {
        //если дубликат в инвентаре не найден
        if (FindCellDublicate(item) == false)
        {
            InventoryCell inventoryCell = new InventoryCell(item);
            inventoryCells.Add(inventoryCell);

            InteractableItem interactableItem = item.GetComponent<InteractableItem>();
            if (interactableItem != null)
            {
                // уничтожаем компонент перетаскивания
                Destroy(interactableItem);
            }
            Debug.Log("В инвентарь автомобиля добавлен: " + item.GetTypeItem().NameItem + ", тип предмета: " + item.GetTypeItem().GetTypeEnum().ToString());
            return TypeErrorInventory.Fine;
        }
        return TypeErrorInventory.ErrorObjectExist;
    }

    private bool FindCellDublicate(Item item) 
    {
        for (int i = 0; i < inventoryCells.Count; i++)
        {
            if (inventoryCells[i].GetTypeEnumItem() == item.GetTypeEnumItem() && inventoryCells[i].Item.GetTypeItem().NameItem == item.GetTypeItem().NameItem)
            {
                inventoryCells[i].AddDublicate();
                return true;
            }
        }
        return false;
    }

    public int CountItemInventory() 
    {
        return inventoryCells.Count;
    }
}

public enum TypeErrorInventory 
{
    Fine = 0,
    ErrorObjectExist = 1,
}