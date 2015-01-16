using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	public CheckpointManager manager;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(){
		manager.MarkCheckpoint(this);
		Debug.Log("mark");
	}
}
