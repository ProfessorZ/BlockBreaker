using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {
	public bool autoplay = false;
	private Ball ball;
	float mousePosInBlocks = 0;

	void Start(){
		ball = GameObject.FindObjectOfType<Ball>();
	}
	// Update is called once per frame
	void Update () {
		if (!autoplay) {
			MoveWithMouse();
		}
		else
		{
			Autoplay();
		}

	}

	void Autoplay(){
		Vector3 paddlePos = new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);
		Vector3 ballPos = ball.transform.position;
		mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp(ballPos.x,0.617f,15.37f);
		this.transform.position = paddlePos;
	}
	void MoveWithMouse(){
		Vector3 paddlePos = new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);
		mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp(mousePosInBlocks,0.5f,15.5f);
		this.transform.position = paddlePos;
	}
}
