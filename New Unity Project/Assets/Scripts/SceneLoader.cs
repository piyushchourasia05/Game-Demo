using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);

    }
    public void PlaySecpndGame()
    {
        SceneManager.LoadScene(2);

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Next()
    {
        SceneManager.LoadScene(4);
    }
    public void How()
    {
        SceneManager.LoadScene(6);
    }
}
