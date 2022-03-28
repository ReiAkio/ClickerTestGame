using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyImageManager : MonoBehaviour
{
    private void Start()
    {
        foreach (Transform child in transform)
        {
            if (child.name != "Visual")
            {
                child.gameObject.SetActive(false);
            }
            else child.gameObject.SetActive(true);
        }
    }
}
