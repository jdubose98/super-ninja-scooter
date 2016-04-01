using UnityEngine;
using System.Collections;

public class BasicMovementScript : MonoBehaviour {

	[SerializeField] AudioSource m_EngineSound;
	[SerializeField] float MoveSpeed;

	[SerializeField] float RotationDamping; // how fast we'll rotate overall

	[SerializeField] GameObject LeftGameObjectTarget;
	[SerializeField] GameObject RightGameObjectTarget;
	[SerializeField] GameObject ZeroPointTarget;

	[SerializeField] Transform MoverNode;

	int m_TurnState = 0;

	bool rev = false;

	Quaternion targetRotation;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			gameObject.transform.position = Vector3.Lerp(gameObject.transform.position,MoverNode.position,.5f);
			MoverNode.transform.Translate (-MoveSpeed * Time.deltaTime, 0, 0);
			m_TurnState = -1;
		}
		if (Input.GetKey (KeyCode.D)) {
			gameObject.transform.position = Vector3.Lerp(gameObject.transform.position,MoverNode.position,.5f);
			MoverNode.transform.Translate (MoveSpeed * Time.deltaTime, 0, 0);
			m_TurnState = 1;
		}

		if (Input.GetKey (KeyCode.W)) {
			rev = true;
			if (m_EngineSound.pitch < 1.31f) {
				m_EngineSound.pitch += 0.005f;
			}
		}

		if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.D)) {
			m_TurnState = 0;
		}

		if (Input.GetKeyUp (KeyCode.W)) {
			rev = false;
		}

		if (rev == false && m_EngineSound.pitch > .3f) {
			m_EngineSound.pitch -= 0.01f;
		}
			
	}

	// Updates at physics rate, 30fps
	void FixedUpdate(){


		Vector3 currentUp;

		RaycastHit hit;
		if (Physics.Raycast(transform.position, -Vector3.up, out hit, 100)){
			currentUp = hit.normal;
		}

		switch (m_TurnState) {
		case -1:
			targetRotation = Quaternion.LookRotation (Vector3.forward, LeftGameObjectTarget.transform.position);
			Debug.Log ("lel");
			break;
		
		case 0:
			targetRotation = Quaternion.LookRotation (Vector3.forward, ZeroPointTarget.transform.up);
			break;

		case 1:
			targetRotation = Quaternion.LookRotation (Vector3.forward, RightGameObjectTarget.transform.position);
			Debug.Log ("lol");
			break;

		default:
			break;
		}
	
		gameObject.transform.rotation = Quaternion.Slerp (gameObject.transform.rotation, targetRotation, Time.deltaTime * RotationDamping);
	}
}
