using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyProductMenu : MonoBehaviour
{
    private void Start()
    {
        GameObject.Find("MarketCanvas").SetActive(false);
    }

    public void ActiveBuyMenu(GameObject buyProductCanvas)
    {
        buyProductCanvas.gameObject.SetActive(true);
    }

}

