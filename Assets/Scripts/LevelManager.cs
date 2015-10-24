using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	//Load new level, passes along the name of the level to be loaded
	public void loadNewLevel(string name){
		Application.LoadLevel(name);
	}
	public void loadNextLevel(){
		Application.LoadLevel(Application.loadedLevel +1);
	}

	public void quitRequest(){
		Application.Quit ();							// Quits the game
	}
	
}
