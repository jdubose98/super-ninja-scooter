using UnityEngine;
using System.Collections;

public class LookAtRagdoll : MonoBehaviour {

	[SerializeField] GameObject TargetToLookAt;

	// Update is called once per frame
	void Update () {
		gameObject.transform.LookAt (TargetToLookAt.transform);
	}
}
