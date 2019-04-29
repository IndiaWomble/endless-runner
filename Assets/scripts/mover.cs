using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

    float x;
    public float temp = 0.5f;
   
	// Use this for initialization
	void Start () {
        x = gameObject.transform.position.x;
        gameObject.transform.position = new Vector2(15.0f, 2.5f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(gameObject.transform.position.x >= -15.0f)
            gameObject.transform.position = new Vector2(x = x - temp, gameObject.transform.position.y);
        if (gameObject.transform.position.x <= -15.0f)
            Destroy(gameObject);
    }
}
