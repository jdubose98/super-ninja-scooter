using UnityEngine;
using System.Collections;

public class FocusScript : MonoBehaviour {

	void Update() {
		if (Input.GetButtonDown ("Slow Time")) 
			if (Time.timeScale == 1.0F) //when clicking, if focus is off you'll toggle it on
				Time.timeScale = 0.5f;
		 else 
			Time.timeScale = 1.0F; //if focus is on toggle off
		
		Time.fixedDeltaTime = 0.02F * Time.timeScale;
	

}
}