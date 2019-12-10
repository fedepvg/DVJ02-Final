using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIInGame : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI TimeText;
    public delegate float OnGetTime();
    public static OnGetTime OnGetTimeAction;
    public GameObject PausePanel;

    float PrevTime;
    float ActualTime;
    float PrevScore;

    // Update is called once per frame
    void Update()
    {
        if(OnGetTimeAction!=null)
        {
            ActualTime = OnGetTimeAction();
        }
        if (PrevTime != ActualTime)
            TimeText.text = "Time: " + ActualTime.ToString("#.0");
        PrevTime = ActualTime;

        if (PrevScore != GameManager.Instance.ActualScore)
        {
            PrevScore = GameManager.Instance.ActualScore;
            ScoreText.text = "Score: " + PrevScore;
        }
    }

    public void SetPauseState()
    {
        PausePanel.SetActive(!PausePanel.activeSelf);
        if (PausePanel.activeSelf)
            GameManager.Instance.SetTimeScale(0);
        else
            GameManager.Instance.SetTimeScale(1);
    }
}
