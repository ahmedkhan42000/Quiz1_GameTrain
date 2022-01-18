using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownObject : MonoBehaviour
{
    private Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Rb.AddForce(Vector3.right, ForceMode.Force);
    }
}
