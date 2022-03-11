using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clickable : MonoBehaviour
{

    [SerializeField] private Sprite unclicked;
    [SerializeField] private Sprite clicked;

    [SerializeField] private bool clicking;

    public Text scoreText;

    private int score;

    public void PrepareClick()
    {
        if (!clicking)
        {
            clicking = true;
            ChangeImage();
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
        ChangeImage();
    }

    private void ChangeImage()
    {
        GetComponent<Image>().sprite = clicking ? clicked : unclicked;
    }

    private void Score()
    {
        score++;
        scoreText.text = score.ToString();
    }
}