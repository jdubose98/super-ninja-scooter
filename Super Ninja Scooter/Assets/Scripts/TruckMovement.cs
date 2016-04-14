using UnityEngine;
using System.Collections;

public class TruckMovement : MonoBehaviour {
    public float speed;
    void Update()
    {
        transform.Translate(Vector3.forward * speed);
    }
}
