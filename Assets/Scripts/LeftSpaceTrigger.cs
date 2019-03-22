using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSpaceTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Ball")
        {
            //update player score and reset velocity and position
            GameManager.instance.UpdatePlayerScore = true;
            Rigidbody2D rb2d = col.gameObject.GetComponent<Rigidbody2D>();
            rb2d.velocity = Vector2.zero;
            col.gameObject.transform.position = new Vector2(0f, 0f);

        }
    }
}
