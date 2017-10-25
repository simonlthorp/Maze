using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Q" + transform.position);
	}
	
	// Update is called once per frame
	void Update () {


        transform.Translate(2, 0, 0);
        transform.Translate(1, 0, 0);
        transform.Translate(1, 0, 1);
        transform.Translate(2, 0, 1);
    }
}
