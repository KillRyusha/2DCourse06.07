using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{   
    public void OpenScene(int numuber)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(numuber);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
