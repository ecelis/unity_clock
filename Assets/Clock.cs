using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float deegreesPerHour = 30f;  // 30 deegrees interval
    const float deegreesPerMinute = 6f;
    const float deegreesPerSecond = 6f;

    public Transform hoursTransform;
    public Transform minutesTransform;
    public Transform secondsTransform;
    public bool continuous;

    void UpdateContinuous () {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursTransform.localRotation = Quaternion.Euler(
            0f,  // must be float
            (float)time.TotalHours * deegreesPerHour,
            0f);
        minutesTransform.localRotation = Quaternion.Euler(
            0f,
            (float)time.TotalMinutes * deegreesPerMinute,
            0f);
        secondsTransform.localRotation = Quaternion.Euler(
            0f,
            (float)time.TotalSeconds * deegreesPerSecond,
            0f);
    }
    void UpdateDiscrete()
    {
        DateTime time = DateTime.Now;
        hoursTransform.localRotation = Quaternion.Euler(
            0f,  // must be float
            DateTime.Now.Hour * deegreesPerHour,
            0f);
        minutesTransform.localRotation = Quaternion.Euler(
            0f,
            DateTime.Now.Minute * deegreesPerMinute,
            0f);
        secondsTransform.localRotation = Quaternion.Euler(
            0f,
            DateTime.Now.Second * deegreesPerSecond,
            0f);
    }

    //void Awake () {
    void Update () {
        Debug.Log(DateTime.Now);
        if (continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscrete();
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
}
