using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyingProduct : MonoBehaviour
{
    public Product product;
    public Clickable click;
    public GameObject productObject;
    void Awake() //1 para 1 - cada product(scriptable object) é vinculado à 1 botão. Não pode ter 2 botão com o mesmo product
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
