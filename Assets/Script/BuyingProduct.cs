using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyingProduct : MonoBehaviour
{
    public Product product;
    public Clickable click;
    public GameObject productObject;
    void Start()
    {
        product.AddQueueCost();
        product.AddQueueImage();
    }

    public void BuyButton()
    {
        if (product.costQueue.Peek() <= click.score)
            {
                click.score -= product.costQueue.Dequeue();
                click.scoreText.text = click.score.ToString();
                productObject.SetActive(true);
                productObject.GetComponent<Image>().sprite = product.imageQueue.Dequeue();
            }
        
    }
}
