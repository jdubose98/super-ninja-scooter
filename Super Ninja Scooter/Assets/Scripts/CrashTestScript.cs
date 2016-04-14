using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class CrashTestScript : MonoBehaviour {

	[SerializeField] GameObject PlayerObject;
	[SerializeField] GameObject Ragdoll;
	[SerializeField] AudioSource CrashSound;
	[SerializeField] AudioMixerSnapshot DefaultSnapshot;
	[SerializeField] AudioMixerSnapshot DeadSnapshot;

	// Use this for initialization
	void Start () {
		DefaultSnapshot.TransitionTo (0f);
	}
	
	// Update is called once per frame
//	void Update () {
//		if (Input.GetKeyDown (KeyCode.LeftControl)) {
//			Crash ();
//		}
//	}

	void FixedUpdate(){
		Ragdoll.transform.position = new Vector3(GameObject.Find ("MoverNode").transform.position.x, 0,0);
	}

	void Restart(){
		SceneManager.LoadScene ("TestDriveScene");
	}

	void OnTriggerEnter(Collider collision){
		Debug.Log ("I hit a thing!");
		if (collision.tag == "KillObject") {
			Crash ();
		}
	}

	void Crash(){
		PlayerObject.SetActive (false);
		Ragdoll.SetActive (true);
		Ragdoll.GetComponentInChildren<Rigidbody> ().AddForce (new Vector3 (0, 5000f, 5000f));
		CrashSound.Play ();
		DeadSnapshot.TransitionTo (3f);
		Invoke ("Restart", 5);
	}
}
