using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    public float PickupScore;

    float Score;

    private void Start()
    {
        PlayerController.OnPickupAction = AddScore;
        TimeManager.OnTimeEndedAction = EndGame;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        Score = 0;
    }

    void EndGame()
    {
        Debug.Log("zarlanga");
        LoaderManager.Instance.LoadScene("SampleScene");
    }

    void SetTimeScale(float timeScale)
    {
        Time.timeScale = timeScale;
    }

    void AddScore()
    {
        Score += PickupScore;
    }
}
