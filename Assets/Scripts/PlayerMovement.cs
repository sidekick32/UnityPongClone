using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float Speed = 5;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MovePlayerUp();
        }
        if( Input.GetKey(KeyCode.DownArrow)){
            MovePlayerDown();
        }
        if (Input.GetKey(KeyCode.S))
        {
            ScreenCapture.CaptureScreenshot("GamePic");
        }
        //Catch a copy transform position to use with clamping
        Vector3 Clamp = transform.position;
        // Send the y to the clamp
        Clamp.y = Mathf.Clamp(transform.position.y, -3.49f, 3.52f);
        // Update new transform position
        transform.position = Clamp;
    }

    void MovePlayerUp()
    {
        transform.position += Vector3.up * Speed * Time.deltaTime; 
    }

    void MovePlayerDown()
    {
        transform.position += Vector3.down * Speed * Time.deltaTime;
    }
}





