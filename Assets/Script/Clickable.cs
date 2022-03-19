using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clickable : MonoBehaviour
{

    [SerializeField] private Sprite unclicked;
    [SerializeField] private Sprite clicked;

    [SerializeField] private bool clicking;

    public VisualItem vi;
    public Text scoreText;
    public Product pd;

    private int score;
    

    public void PrepareClick()
    {
        if (!clicking)
        {
            clicking = true;
        }
        else
        {
            StopCoroutine("Click");
        }

        StartCoroutine("Click");
    }

    public IEnumerator Click()
    {
        Score();

        yield return new WaitForSeconds(0.5f);
        clicking = false;
        
    }
    
    public void Buying()
    {
        if (getScore() >= 10)
        {
            score = getScore() - pd.cost;
            vi.Test();
        }
        else
        {
            score = getScore();
        }
    }

    private void Score()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public int getScore()
    {
        return score;
    }
}
