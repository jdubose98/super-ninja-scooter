using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class CrashTestScript : MonoBehaviour {

	[SerializeField] GameObject Ragdoll;
	[SerializeField] AudioSource CrashSound;
	[SerializeField] AudioMixerSnapshot DefaultSnapshot;
	[SerializeField] AudioMixerSnapshot DeadSnapshot;
    [SerializeField] GameObject Player;
	// Use this for initialization
	void Start () {
		DefaultSnapshot.TransitionTo (0f);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate(){
		Ragdoll.transform.position = new Vector3(GameObject.Find ("MoverNode").transform.position.x, 0,0);
	}

	void Restart(){
		SceneManager.LoadScene ("TestDriveScene");
	}

	void OnTriggerEnter(Collider other){
        Crash();
	}

	public void Crash(){
		gameObject.SetActive (false);
		Ragdoll.SetActive (true);
		Ragdoll.GetComponentInChildren<Rigidbody> ().AddForce (new Vector3 (0, 5000f, 5000f));
		CrashSound.Play ();
		DeadSnapshot.TransitionTo (3f);
		Invoke ("Restart", 5);
	}
}
