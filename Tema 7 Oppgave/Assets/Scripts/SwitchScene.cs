using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public GameObject panel;

    private void Start()
    {
        panel.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetTrue()
    {
        panel.SetActive(true);
    }

    public void SetFalse()
    {
        panel.SetActive(false);
    }
}
