using UnityEngine;
using System.Collections;
using UnityEngine.Audio;


public class FocusScript : MonoBehaviour {

	[SerializeField] AudioMixerSnapshot DefaultSnapshot;
	[SerializeField] AudioMixerSnapshot FocusedSnapshot;

	void Update() {
		if (Input.GetKeyDown (KeyCode.CapsLock))
		if (Time.timeScale == 1.0F) { //when clicking, if focus is off you'll toggle it on
			Time.timeScale = 0.5f;
			FocusedSnapshot.TransitionTo (.1f);
		} else {
			Time.timeScale = 1.0F;
			DefaultSnapshot.TransitionTo (.1f);
		}//if focus is on toggle off
		
		Time.fixedDeltaTime = 0.02F * Time.timeScale;
	

}
}