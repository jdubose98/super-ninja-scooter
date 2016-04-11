using UnityEngine;
using System.Collections;

public class TextTutorialTranslator : MonoBehaviour {

	[SerializeField] float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (0, 0, -moveSpeed * Time.deltaTime);
	}
}
