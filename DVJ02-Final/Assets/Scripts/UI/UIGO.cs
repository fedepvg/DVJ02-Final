using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIGO : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;

    void Start()
    {
        ScoreText.text = "Score: " + GameManager.Instance.ActualScore;
    }
}
