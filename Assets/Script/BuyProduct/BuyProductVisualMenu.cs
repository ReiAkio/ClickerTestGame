using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyProductVisualMenu : MonoBehaviour
{
    public GameObject buyProductImage;
    public GameObject thisBuyProductImage;
    
    public void BuyProductVisualButtons()
    {
        buyProductImage.SetActive(false);
        thisBuyProductImage.SetActive(true);
    }
}
