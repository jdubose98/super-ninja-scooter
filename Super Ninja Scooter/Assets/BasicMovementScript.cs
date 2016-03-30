using UnityEngine;
using System.Collections;

public class BasicMovementScript : MonoBehaviour {

	int m_TurnState = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			Debug.Log ("hello world");
			transform.Translate( new Vector3 (-0.03f,0f,0f) );
			m_TurnState = -1;
		}
		if (Input.GetKey (KeyCode.D)) {
			Debug.Log ("goodbye world");
			transform.Translate( new Vector3 (0.03f,0f,0f) );
			m_TurnState = 1;
		}
		if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.D)) {
			m_TurnState = 0;
		}

		if (m_TurnState != 0) {
			if (m_TurnState == -1) {
				if (transform.rotation.z > 0) {
					Quaternion.Euler(0,0,-0.1f);
				}
			}
			else
				if (transform.rotation.z < 0) {
					Quaternion.Euler(0,0,0.1f);
				}
		}
		else {
			// return to 0.
		}
	}
}
