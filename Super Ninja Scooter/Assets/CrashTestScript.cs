using UnityEngine;
using System.Collections;

public class CrashTestScript : MonoBehaviour {

	[SerializeField] GameObject Ragdoll;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			gameObject.SetActive (false);
			Ragdoll.SetActive (true);
			Ragdoll.GetComponentInChildren<Rigidbody> ().AddForce (new Vector3 (0, 5000f, 5000f));
		}
	}
}
