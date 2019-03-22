using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager instance;  //makes GameManager exist for all objects
    public Text PlayerScore;             //Onscreen score text for Player
    public Text CpuScore;                //Onscreen score text for Cpu
    public bool UpdatePlayerScore = false;
    public bool UpdateCpuScore = false;
    private int PlayerCurScore = 0;
    private int CpuCurScore = 0;
	// Use this for initialization
	void Awake () {
        //Singleton pattern allows only 1 GameManager in game
		if(instance != null)             
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (UpdateCpuScore)
        {
            
            CpuCurScore += 1;
            CpuScore.text = "" + CpuCurScore;
          //if cpu wins reset score and call lost screen
            if (CpuCurScore == 10 )
            {
                CpuCurScore = 0;
                CpuScore.text = "" + CpuCurScore;
                StartGame("Lost");
            }
            UpdateCpuScore = false;
        }
        if (UpdatePlayerScore)
        {
            PlayerCurScore += 1;
            PlayerScore.text = "" + PlayerCurScore;
            
            //if player wins reset score and call win screen
            if (PlayerCurScore == 10 )
            {
                PlayerCurScore = 0;
                PlayerScore.text = "" + PlayerCurScore;
                StartGame("Win");
            }
            UpdatePlayerScore = false;
        }
	}

    public void StartGame(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
