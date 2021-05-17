using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRespawn : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -4.5F)
        {
            transform.position = new Vector3(-37.45F, 10.72F, -0.38F);
        }
    }
}
