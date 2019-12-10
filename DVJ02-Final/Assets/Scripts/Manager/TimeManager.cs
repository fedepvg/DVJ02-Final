using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float GameTime;
    public delegate void OnTimeEnded(float time);
    public static OnTimeEnded OnTimeEndedAction;

    public float TimeLeft;

    void Start()
    {
        TimeLeft = GameTime;
        UIInGame.OnGetTimeAction = GetTimeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        TimeLeft -= Time.deltaTime;
        if (TimeLeft <= 0)
        {
            if (OnTimeEndedAction != null)
                OnTimeEndedAction(GameTime - TimeLeft);
        }
    }

    float GetTimeLeft()
    {
        return TimeLeft;
    }
}
