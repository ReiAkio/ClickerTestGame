using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyingVisualItem : MonoBehaviour
{
    public VisualItem visualItem;
    public Clickable clickable;
    public InventoryManager inventoryManager;

    public void Start()
    {
        GetComponent<Image>().sprite = visualItem.image;
    }

    public void BuyVisualItem()
    {
        if (visualItem.cost <= clickable.score)
        {
            clickable.RemoveScore(visualItem.cost);
            inventoryManager.Add(visualItem);
        }
    }
}
