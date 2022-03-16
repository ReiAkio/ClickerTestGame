using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSpriteWithScore : MonoBehaviour
{
    public Clickable clickable;
    public List<Sprite> newListofSprite;
    public List<int> restrictionNumber;
    void Start()
    {
        
    }

    void Update()
    {
        ChangeSpritewithScore(0);
    }
    
    private void ChangeSpritewithScore(int i)
    {
        foreach (var sprite in newListofSprite)
        {
            if (clickable.score >= restrictionNumber[i]) GetComponent<Image>().sprite = newListofSprite[i];
            i++;
        }
    }
    
}
