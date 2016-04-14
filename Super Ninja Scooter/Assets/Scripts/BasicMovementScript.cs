using UnityEngine;
using System.Collections;

public class BasicMovementScript : MonoBehaviour {

	[SerializeField] AudioSource m_EngineSound;
	[SerializeField] float MoveSpeed;

	[SerializeField] float RotationDamping; // how fast we'll rotate overall

	[SerializeField] GameObject LeftGameObjectTarget;
	[SerializeField] GameObject RightGameObjectTarget;
	[SerializeField] GameObject ZeroPointTarget;

	[SerializeField] GameObject MovingObjects;

	[SerializeField] Transform MoverNode;

	[SerializeField] Animator m_Animator;

	int m_TurnState = 0;

	bool rev = false;

	Quaternion targetRotation;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			gameObject.transform.Translate (-MoveSpeed * Time.deltaTime, 0, 0);
			m_TurnState = -1;

		}
		if (Input.GetKey (KeyCode.D)) {
			gameObject.transform.Translate (MoveSpeed * Time.deltaTime, 0, 0);

			m_TurnState = 1;

		}

		if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) {
			if (m_TurnState == -1) {
				m_Animator.SetTrigger ("TurnLeft");
			} else {
				m_Animator.SetTrigger ("TurnRight"); 
			}
		}

		
		if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.D)) {
			if (m_TurnState == -1) {
				m_Animator.SetTrigger ("ReleaseLeft");
			} else {
				m_Animator.SetTrigger ("ReleaseRight"); 
			}
			m_TurnState = 0;
		}

		m_EngineSound.pitch = .3f + MovingObjects.GetComponent<TextTutorialTranslator>().moveSpeed * 0.07f;
			
	}

	// Updates at physics rate, 30fps
//	void FixedUpdate(){
//
////		Vector3 currentUp;
//
////		RaycastHit hit;
////		if (Physics.Raycast(transform.position, -Vector3.up, out hit, 100)){
////			currentUp = hit.normal;
////		}
////
////		switch (m_TurnState) {
////		case -1:
////			targetRotation = Quaternion.LookRotation (Vector3.forward, LeftGameObjectTarget.transform.position);
////			Debug.Log ("lel");
////			break;
////		
////		case 0:
////			targetRotation = Quaternion.LookRotation (Vector3.forward, ZeroPointTarget.transform.up);
////			break;
////
////		case 1:
////			targetRotation = Quaternion.LookRotation (Vector3.forward, RightGameObjectTarget.transform.position);
////			Debug.Log ("lol");
////			break;
////
////		default:
////			break;
////		}
//	
//		//gameObject.transform.rotation = Quaternion.Lerp (gameObject.transform.rotation, targetRotation, Time.deltaTime * RotationDamping);
//	}
}
