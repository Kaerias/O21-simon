using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	private float startimer;
	private int timerMax;

	// Use this for initialization
	void Start () {
		startimer = 2;
		timerMax = 2;
	}
	
	// Update is called once per frame
	void Update () {
		startimer -= Time.deltaTime;
		if (startimer <= 0)
			startimer = timerMax;
	}

	public float GetStartimer()
	{
		return startimer;
	}
}
