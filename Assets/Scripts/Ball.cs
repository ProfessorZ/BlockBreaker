using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private PaddleController paddle;
	private Vector3 paddleToBallVector;
	private bool hasStarted = false;
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<PaddleController>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector;	
		
			if (Input.GetMouseButtonDown(0)) {
				hasStarted = true;
				this.rigidbody2D.velocity = new Vector2 (2f,12f);
			}
		}
	}
	void OnCollisionEnter2D(Collision2D coll){
		Vector2 tweakSpeed = new Vector2(Random.Range (0.0f,0.2f),Random.Range (0.0f,0.2f));
		if (hasStarted) {
			audio.Play();		
			this.rigidbody2D.velocity += tweakSpeed;
		}
	}
}
