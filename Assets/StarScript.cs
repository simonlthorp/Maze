using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour {

    private ParticleSystem stars;
    private bool starsEnabled;

	// Use this for initialization
	void Start () {
        stars = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if(transform.rotation.x < 0)
        {
            starsEnabled = false;
        }

        var emission = stars.emission;
        emission.enabled = starsEnabled;

    }
}
