using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI p1text;
    public TextMeshProUGUI p2text;

    private int p1score;
    private int p2score;

    // Update is called once per frame
    void Update()
    {
        p1text.text = p1score.ToString();
        p2text.text = p2score.ToString();
    }

    public void AddPoint(int player)
    {
        if (player == 1)
        {
            p1score++;
        } else
        {
            p2score++;
        }
    }
}
