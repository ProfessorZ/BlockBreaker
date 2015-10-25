﻿using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	private LevelManager levelManager;

	void OnTriggerEnter2D(Collider2D trigger){
		Brick.breakableCount = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		levelManager.loadNewLevel("Lose");
	}
	void OnCollisionEnter2D(Collision2D collision){
		Debug.Log ("Collision");

	}
}
