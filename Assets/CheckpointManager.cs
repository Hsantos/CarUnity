using UnityEngine;
using System.Collections;

public class CheckpointManager : MonoBehaviour {


	public Checkpoint[] checkpoints;
	private int currentCheckpoint;

	// Use this for initialization
	void Start () {
		currentCheckpoint = 0;
		for(int i = 0; i < checkpoints.Length; i++){
			checkpoints[i].manager = this;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void MarkCheckpoint(Checkpoint c){
		if (checkpoints[currentCheckpoint] == c){
			currentCheckpoint++;
		}
		if (currentCheckpoint == checkpoints.Length){
			//you win
			Timer.main.laps += 1;
			currentCheckpoint = 0;
		}
	}
}
