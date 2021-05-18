using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnObject : MonoBehaviour
{
    private Vector3 scale, position;
    private Quaternion rotation;

    void Start() 
    {
        position = transform.position;
        scale = transform.localScale;
        rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x || transform.position.y || transform.position.z )
        if (transform.position.y <= -5F)
        {
            transform.position = position;
            transform.localScale = scale;
            transform.rotation = rotation;
            GetComponent<Rigidbody>().velocity = new Vector3(0f,0f,0f); 
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0f,0f,0f);
        }
    }
}
