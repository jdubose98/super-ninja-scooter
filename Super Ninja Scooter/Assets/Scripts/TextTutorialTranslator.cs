using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextTutorialTranslator : MonoBehaviour {

	public float moveSpeed;

	float waitInterval;
	float waitTime;

	// Use this for initialization
	void Start () {
		waitInterval = 0.5f;
		waitTime = waitInterval;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (0, 0, -moveSpeed * Time.deltaTime);
		SpeedUp ();
	}

	void SpeedUp(){
		if (waitTime < Time.time) {
			moveSpeed += .33f;
			waitInterval = waitInterval * 1.05f;
			waitTime = Time.time + waitInterval;
		}
	}
}
