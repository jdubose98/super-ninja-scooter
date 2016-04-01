using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestComboScript : MonoBehaviour {

	[SerializeField] Animator m_anim;
	[SerializeField] Image m_FillImage;
	[SerializeField] AudioSource m_WhamNoise;
	[SerializeField] Text ComboText;

	public int ComboCount;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftControl)){
			m_anim.SetTrigger ("Wombo");
			ComboCount += 1;
			ComboText.text = ComboCount + "x";
		}
	}
}
