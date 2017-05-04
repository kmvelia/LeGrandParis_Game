using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footer : MonoBehaviour {

    public static float _timer;

	// Use this for initialization
	void Start ()
    {
        _timer = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(Time.time - _timer);
        if (Time.time - _timer > 3)
            this.gameObject.SetActive(false);
    }
}
