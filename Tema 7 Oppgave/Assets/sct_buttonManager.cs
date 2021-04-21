using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sct_buttonManager : MonoBehaviour
{
    public void BridgeScene()
    {
        sct_GameManager.Instance.time += 1;
        SceneManager.LoadScene("6_Brovei");
    }
    public void CorrectScene()
    {
        //SceneManager.LoadScene();
    }

}
