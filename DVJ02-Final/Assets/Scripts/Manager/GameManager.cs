using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    public SceneLoader SceneLoader;

    int Score;

    private void Start()
    {
        PickupBehaviour.OnPickupAction = AddScore;
        TimeManager.OnTimeEndedAction = EndGame;
    }

    void StartGame()
    {
        Score = 0;
    }

    void EndGame()
    {
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
}
