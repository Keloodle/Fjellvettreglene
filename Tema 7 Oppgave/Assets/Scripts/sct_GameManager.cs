using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sct_GameManager : MonoBehaviour
{
    private static sct_GameManager instance;
    public static sct_GameManager Instance => instance;

    public int time = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    void Update()
    {
        
    }
}
