using UnityEngine;
using System.Collections;

public class Flip : MonoBehaviour {
     CrashTestScript Crashing;
void OnTriggerEnter(Collider other)
    {
        Crashing.Crash();
    }
}
