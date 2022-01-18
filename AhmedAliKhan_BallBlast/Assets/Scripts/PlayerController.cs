using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalInput;
    public float Speed = 10;
    private float xBoundry = 12;
    public GameObject ProjecticePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xBoundry)
        {
            transform.position = new Vector3(-xBoundry,transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBoundry)
        {
            transform.position = new Vector3(xBoundry, transform.position.y, transform.position.z);
        }
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(ProjecticePrefab,transform.position, ProjecticePrefab.transform.rotation);
        }
      
    }
}
