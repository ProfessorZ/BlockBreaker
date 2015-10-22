using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	//Load new level, passes along the name of the level to be loaded
	public void loadNewLevel(string name){
		Application.LoadLevel(name);
		//DontDestroyOnLoad(NumberSettings.settings);		// Makes sure Settings are saved between the levels.
	}

	public void quitRequest(){
		Application.Quit ();							// Quits the game
	}
	
}
