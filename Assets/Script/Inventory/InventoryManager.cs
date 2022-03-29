using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private List<BuffItem> listBuffItems = new List<BuffItem>();
    private List<VisualItem> listVisualItems = new List<VisualItem>();
    public event Action<BuffItem> InventoryBuffItemChangedEvent;
    public event Action<VisualItem> InventoruVisualItemChangedEvent; 

    public void Add(VisualItem visualItem)
    {
        listVisualItems.Add(visualItem);
        InventoruVisualItemChangedEvent?.Invoke(visualItem);
    }
    
    public void Add(BuffItem buffItem)
    {
        listBuffItems.Add(buffItem);
        InventoryBuffItemChangedEvent?.Invoke(buffItem);

    }
    
}
