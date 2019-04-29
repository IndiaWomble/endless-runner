using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {

    int s;
    GameObject obstacle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (obstacle.transform.position.x <= -12.0f)
            s++;
	}
}
