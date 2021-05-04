using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    [SerializeField]
    GameObject door;

    bool isOpened = false;

    void OnTriggerEnter(Collider col)
    {
        if (!isOpened)
        {
            isOpened = true;
	    door.transform.position += new Vector3 (0, 13, 0);
        }
    }
}