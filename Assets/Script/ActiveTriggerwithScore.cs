using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ActiveTriggerwithScore : MonoBehaviour
{
    public Clickable clickable;
    public List<GameObject> newListofObject;
    public List<int> restrictionNumber;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TriggerwithScore(0);
    }
    
    private void TriggerwithScore(int i)
    {
        foreach (var newObject in newListofObject)
        {
            if (clickable.score >= restrictionNumber[i]) newListofObject[i].SetActive(true);
            i++;
        }
    }
}
