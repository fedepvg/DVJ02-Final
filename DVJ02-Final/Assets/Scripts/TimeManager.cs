using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float GameTime;
    public delegate void OnTimeEnded();
    public static OnTimeEnded OnTimeEndedAction;

    float TimeLeft;

    void Start()
    {
        TimeLeft = GameTime;
    }

    // Update is called once per frame
    void Update()
    {
        TimeLeft -= Time.deltaTime;
        if (TimeLeft <= 0)
        {
            if (OnTimeEndedAction != null)
                OnTimeEndedAction();
        }

    }
}
