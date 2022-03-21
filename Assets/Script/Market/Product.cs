using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Product : ScriptableObject
{
    public new string name;
    public List<int> cost;
    public List<Sprite> image;
    public Queue<int> costQueue = new Queue<int>();
    public Queue<Sprite> imageQueue = new Queue<Sprite>();

    public void AddQueueCost()
    {
        foreach (var cost in cost)
        {
            costQueue.Enqueue(cost);
        }
    }

    public void AddQueueImage()
    {
        foreach (var sprite in image)
        {
            imageQueue.Enqueue(sprite);
        }  
    }


}
