using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    public SceneLoader SceneLoader;

    int Score;
    float PrevGameTime;

    private void Start()
    {
        PickupBehaviour.OnPickupAction = AddScore;
        TimeManager.OnTimeEndedAction = EndGame;
        PlayerController.OnStartAction = StartGame;
    }

    void StartGame()
    {
        Score = 0;
        SetTimeScale(1);
    }

    void EndGame(float time)
    {
        PrevGameTime = time;
        UpdatePlayerPrefs();
        this.SceneLoader.LoadGOScene();
    }

    public void SetTimeScale(float timeScale)
    {
        Time.timeScale = timeScale;
    }

    void AddScore(int pickupScore)
    {
        Score += pickupScore;
    }

    public int ActualScore
    {
        get { return Score; }
    }
    
    public float GameTime
    {
        get { return PrevGameTime; }
    }

    void UpdatePlayerPrefs()
    {
        PlayerPrefs.SetInt("PrevScore", Score);
        int highscore;
        if (PlayerPrefs.HasKey("Highscore"))
            highscore = PlayerPrefs.GetInt("Highscore");
        else
            highscore = 0;

        if (Score > highscore)
                PlayerPrefs.SetInt("Highscore", Score);
    }
}
