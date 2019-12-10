using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIGO : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI HighscoreText;
    public TextMeshProUGUI TimeText;

    void Start()
    {
        ScoreText.text = "Score: " + GameManager.Instance.ActualScore;
        if(PlayerPrefs.HasKey("Highscore"))
            HighscoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore");
        TimeText.text = "Time: " + GameManager.Instance.GameTime.ToString("#.0");
    }
}
