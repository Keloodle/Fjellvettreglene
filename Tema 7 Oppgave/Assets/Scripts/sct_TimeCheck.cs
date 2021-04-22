using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sct_TimeCheck : MonoBehaviour
{
    [SerializeField]
    public enum TimeStates{Morning, Day, Night}
    TimeStates timeState;
  
    void Start()
    {
        switch (sct_GameManager.Instance.time)
        {
            case 1:
                timeState = TimeStates.Morning;
                break;
            case 2:
                timeState = TimeStates.Day;
                break;
            case 3:
                timeState = TimeStates.Night;
                break;
            default:
                timeState = TimeStates.Night;
                break;
        }
        switch (timeState)
        {
            case TimeStates.Morning:
                transform.GetChild(0).gameObject.SetActive(true);
                break;
            case TimeStates.Day:
                transform.GetChild(1).gameObject.SetActive(true);
                break;
            case TimeStates.Night:
                transform.GetChild(2).gameObject.SetActive(true);
                break;
            default:
                break;
        }
    }
}
