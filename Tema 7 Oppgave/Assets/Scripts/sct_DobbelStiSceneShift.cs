using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sct_DobbelStiSceneShift : MonoBehaviour
{

    public void TiKilometerSkilt()
    {
        SceneManager.LoadScene(5);
    }

    public void FemKilometerSkilt()
    {
        SceneManager.LoadScene(1);
    }

    public void FemKilometerNoon()
    {
        SceneManager.LoadScene("blank");
    }    
    
    public void TiKilometerNoon()
    {
        SceneManager.LoadScene("blank");
    }
    public void FemKilometerNatt()
    {
        SceneManager.LoadScene("blank");
    }
    public void TiKilometerNatt()
    {
        SceneManager.LoadScene("blank");
    }

}
