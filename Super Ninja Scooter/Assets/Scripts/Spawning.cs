using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawning : MonoBehaviour {

    public List<GameObject> preFabList = new List<GameObject>();
    public List<GameObject> SpawnPointList = new List<GameObject>();
    GameObject clone;
    void Start()
    {

        StartCoroutine(SpawnUp());

    }
    IEnumerator SpawnUp()
    {
        int preFabIndex = Random.Range(0, 3);
        int SpawnPointIndex = Random.Range(0, 5);
        yield return new WaitForSeconds(1.1f);
        clone = (GameObject)Instantiate(preFabList[preFabIndex], SpawnPointList[SpawnPointIndex].transform.position, SpawnPointList[SpawnPointIndex].transform.rotation);
        Destroying();
        
    }
    void Destroying()
    {

        Destroy(clone, 20f);
    }
}
