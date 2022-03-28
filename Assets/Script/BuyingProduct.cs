using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyingProduct : MonoBehaviour
{

    public BuffItem buffItem;
    public Clickable clickable;
    public InventoryManager inventoryManager;

    public void Start()
    {
        GetComponent<Image>().sprite = buffItem.image;
    }

    public void BuyBuffItem()
    {
        if (buffItem.cost <= clickable.score)
        {
            clickable.RemoveScore(buffItem.cost);
            inventoryManager.Add(buffItem);
        }
    }

}
