using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private List<BuffItem> listBuffItems = new List<BuffItem>();
    private List<BuffItem> listVisualItems = new List<BuffItem>();
    public event Action<BuffItem> InventoryBuffItemChangedEvent;

    public void Add(VisualItem visualItem)
    {
        
    }
    
    public void Add(BuffItem buffItem)
    {
        listBuffItems.Add(buffItem);
        InventoryBuffItemChangedEvent?.Invoke(buffItem);

    }
    
}
