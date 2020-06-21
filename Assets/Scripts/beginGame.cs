using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class beginGame : MonoBehaviour
{
   
    public void startgame()
    {
        SceneManager.LoadScene("Begin");
    }

    public void startlevel()
    {
        SceneManager.LoadScene("level1");
    }
    public void quitgame()
    {
        Application.Quit();
        print("die potato");
    }
}
