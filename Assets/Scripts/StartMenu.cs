using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

    public void StartGame(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
