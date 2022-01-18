using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundry : MonoBehaviour
{
    private float topbound = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topbound)
        {
            Destroy(gameObject);
        }
    }
}
