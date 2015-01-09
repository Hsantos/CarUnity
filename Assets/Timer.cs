using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public TextMesh text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		text.text = Time.time + "";
	}
}
