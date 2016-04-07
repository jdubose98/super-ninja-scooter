using UnityEngine;
using System.Collections;

public class Spinner : MonoBehaviour {

	[SerializeField] int SpinSpeed;

    void Awake()
    {
        Time.timeScale = 1;
    }

	// Use this for initialization
	void FixedUpdate()
    {
		gameObject.transform.Rotate(new Vector3(SpinSpeed*Time.deltaTime,0,0));
    }
}