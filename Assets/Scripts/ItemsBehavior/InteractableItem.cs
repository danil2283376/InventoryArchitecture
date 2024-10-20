using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractableItem : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public Transform parentToReturnTo;
    public Transform parentToReturnFrom;
    public InventoryCar InventoryCar;

    public float radius = 1f;
    public Color color = Color.red;

    private CanvasGroup canvasGroup;
    private Vector3 initialPosition;
    private Item item;

    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        //parentToReturnTo = transform.parent;
        parentToReturnFrom = transform.parent;
        initialPosition = transform.position;
        item = GetComponent<Item>();
        if (item == null)
            Debug.LogError("На предмете обязана быть реализация Item!");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
        transform.SetParent(transform.parent.parent);
        transform.position = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        LayerMask inventoryMask = 1 << 6;

        List<Collider2D> colliders = Physics2D.OverlapCircleAll(transform.position, 15f, inventoryMask).ToList();
        Debug.Log(colliders.Count);

        if (colliders.Count > 0)
        {
            //перемещение в инвентарь
            transform.SetParent(parentToReturnTo);
            TypeErrorInventory typeErrorInventory = InventoryCar.AddItemInventory(item);
            if (typeErrorInventory == TypeErrorInventory.ErrorObjectExist)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            // перемещение обратно на полку
            transform.SetParent(parentToReturnFrom);
            transform.position = initialPosition;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = color;

        // Отрисовка сферы
        Gizmos.DrawSphere(transform.position, radius);
    }

}
