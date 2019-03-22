using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lost : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     
	}

    public void PlayAgain()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.StartGame("Scene_01");
        }
        else
            print("GameManger.instance not found");

    }
    public void Exit()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.ExitGame();
        }
    }
}
