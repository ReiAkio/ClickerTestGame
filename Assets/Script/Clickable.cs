using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Clickable : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Text scoreText;
    public int score;

    public void Score()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void RemoveScore(int qtt)
    {
        score -= qtt;
        scoreText.text = score.ToString();
    }

    public int getScore()
    {
        return score;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Botão Abaixou
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Botão levantou
    }
}
