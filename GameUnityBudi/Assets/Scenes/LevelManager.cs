using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("startGame");
    }
    public void Quit()
    {

        Application.Quit();
    }
}
