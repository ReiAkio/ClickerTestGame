using UnityEngine;
using UnityEngine.UI;


public class ChangeOpacityItem : MonoBehaviour
{
    public Image image;
    public InventoryManager inventoryManager;

    public void Start()
    {
        inventoryManager.InventoryBuffItemChangedEvent += onInventoryChanged;
    }

    public void onInventoryChanged(Product product)
    {
        image.sprite = product.image;
        image.color = new Color(1, 1, 1, 0.5f);
    }
}
