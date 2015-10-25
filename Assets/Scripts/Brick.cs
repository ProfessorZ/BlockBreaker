using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public static int breakableCount = 0;

	public Sprite[] hitSprites;
	public int maxHits;
	private int timesHit;
	private bool isBreakable;

	private LevelManager levelManager;
	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		if (isBreakable) {
			breakableCount++; 
		}
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	void Awake(){
		breakableCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collider){
		if (isBreakable){
		HandleHits();
		}

		Debug.Log (breakableCount.ToString());
	}

	void HandleHits (){
		timesHit++;
		if (timesHit >= hitSprites.Length+1) {
			breakableCount--;
			levelManager.BrickDestroyed();
			Destroy(gameObject);
			Debug.Log("Brick Kaput!");
		}
		else {
			LoadSprites();
		}
	}
	// TODO Remove this method once we can actually win!
	void SimulateWin(){
		levelManager.loadNextLevel();
	}

	void LoadSprites(){
		int spriteIndex = timesHit-1;
		if(hitSprites[spriteIndex]){
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}
	}
}

