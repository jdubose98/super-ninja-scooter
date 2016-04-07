using UnityEngine;
using System.Collections;

public class SwitchViews : MonoBehaviour {

	[SerializeField] Animator m_Animator;

	bool ThirdPerson = true;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			if (ThirdPerson == true) {
				ThirdPerson = false;
				m_Animator.SetTrigger ("GoFPS");
			} 
			else {
				ThirdPerson = true;
				m_Animator.SetTrigger ("ReleaseFPS");
			}
		}
	}
}
