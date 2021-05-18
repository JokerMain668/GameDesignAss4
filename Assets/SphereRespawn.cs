using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRespawn : MonoBehaviour
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
        if (transform.position.y <= -5F || transform.position.x >= -34.5F)
        {
            transform.position = position;
            transform.localScale = scale;
            transform.rotation = rotation;
        }
    }
}

