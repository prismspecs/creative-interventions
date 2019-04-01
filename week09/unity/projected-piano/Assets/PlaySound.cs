using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    public KeyCode myKey;
    private AudioSource myAudioSource;

    public Color myColor;

	// Use this for initialization
	void Start () {
        myAudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(myKey))
        {
            myAudioSource.Play();
        }

        if (myAudioSource.isPlaying)
        {
            gameObject.GetComponent<Renderer>().material.color = myColor;
        } else {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
