using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private int addHour;
    const float degreesPerHour = 30f;
    const float degreesPerMinutes = 6f;
    const float degreesPerSecond = 6f;

    public Transform hoursTransform, minutesTranform, secondsTranform;

    public bool continuous;
    private void Awake()
    {
        DateTime time = DateTime.Now;
        TimeSpan timechange = new System.TimeSpan(addHour, 0, 0);
        DateTime setTime = time.Add(timechange);
        hoursTransform.localRotation = Quaternion.Euler(0f, setTime.Hour * degreesPerHour, 0f);
        minutesTranform.localRotation = Quaternion.Euler(0f, setTime.Minute * degreesPerMinutes, 0f);
        secondsTranform.localRotation = Quaternion.Euler(0f, setTime.Second * degreesPerSecond, 0f);
    }
    private void Update()
    {
        if (continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscription();
        }
        
    }

    void UpdateContinuous()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;

        hoursTransform.localRotation = Quaternion.Euler(0f, (float)time.TotalHours * degreesPerHour, 0f);
        minutesTranform.localRotation = Quaternion.Euler(0f, (float)time.TotalMinutes * degreesPerMinutes, 0f);
        secondsTranform.localRotation = Quaternion.Euler(0f, (float)time.TotalSeconds * degreesPerSecond, 0f);
    }
    void UpdateDiscription()
    {
        DateTime time = DateTime.Now;
        TimeSpan timechange = new System.TimeSpan(addHour, 0, 0);
        DateTime setTime = time.Add(timechange);
        hoursTransform.localRotation = Quaternion.Euler(0f, setTime.Hour * degreesPerHour, 0f);
        minutesTranform.localRotation = Quaternion.Euler(0f, setTime.Minute * degreesPerMinutes, 0f);
        secondsTranform.localRotation = Quaternion.Euler(0f, setTime.Second * degreesPerSecond, 0f);
    }
}
