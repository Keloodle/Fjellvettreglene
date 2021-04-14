using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public GameObject panel;
    public GameObject button;

    private void Start()
    {
        panel.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("1_Hytta");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetTrue()
    {
        panel.SetActive(true);
        button.SetActive(true);
    }

    public void SetFalse()
    {
        panel.SetActive(false);
        button.SetActive(false);
    }
}
