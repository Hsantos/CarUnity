using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public static Timer main;
	public TextMesh text;
	float timeElasped;
	public int laps;

	// Use this for initialization
	void Start () {
		main = this;
		laps = 0;
		timeElasped = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timeElasped += Time.deltaTime;
		text.text = timeElasped + "\n" + "laps: " + laps;
	}
}
