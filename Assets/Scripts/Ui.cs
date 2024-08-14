using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui : MonoBehaviour
{
    public GameObject gameoverscreen;

    public void GameOver()
    {
        gameoverscreen.SetActive(true);
    }

    public void Restart()
    {

        SceneManager.LoadScene(1);

    }
    public void Quit()
    {
        Application.Quit(); 
    }

}


