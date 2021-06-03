using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI text;

    private int score = 0;

    public void UpdateScore()
    {
        score += 1;
        text.text = score.ToString();
    }
}
