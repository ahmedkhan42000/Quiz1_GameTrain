using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ObjectPrefab;
    public int ObjectIndex;
    private Vector3 SpawnPos;
    private float DelayTime = 2;
    private float RepeatTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", DelayTime, RepeatTime );
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void SpawnObjects()
    {
        int objectIndex = Random.Range(0, ObjectPrefab.Length);
        SpawnPos = new Vector3(Random.Range(-12, 12), 1f, 25);
        Instantiate(ObjectPrefab[objectIndex], SpawnPos, ObjectPrefab[objectIndex].transform.rotation);
    }
}
