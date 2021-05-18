using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door, plate, colObject;

    bool isOpened = false;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (!isOpened && colObject == col)
        {
            isOpened = true;
            door.transform.position += new Vector3(0,0,20);
            plate.transform.position -= new Vector3(0,.05F,0);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (isOpened)
        {
            isOpened = false;
            door.transform.position -= new Vector3(0,0,20);
            plate.transform.position += new Vector3(0,.05F,0);
        }
    }
}
