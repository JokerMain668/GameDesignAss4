using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAssist : MonoBehaviour
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
        float dist = Vector3.Distance(new Vector3(-37.1988F, 3.69F, 6.68F),transform.position);
        if (dist >= 1 || dist <= 1)
        {
            transform.position = new Vector3(-37.1988F, 3.69F, 6.68F);
        }
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
