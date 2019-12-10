using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMenu : MonoBehaviour
{
    public TextMeshProUGUI PrevScoreText;
    public TextMeshProUGUI HighscoreText;
    public GameObject MenuPanel;
    public GameObject CreditsPanel;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Highscore"))
            HighscoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore");
        
        if (PlayerPrefs.HasKey("PrevScore"))
            PrevScoreText.text = "Previous Score: " + PlayerPrefs.GetInt("PrevScore");
    }

    public void ActivateCreditsPanel()
    {
        CreditsPanel.SetActive(true);
        MenuPanel.SetActive(false);
    }

    public void DectivateCreditsPanel()
    {
        CreditsPanel.SetActive(false);
        MenuPanel.SetActive(true);
    }
}
