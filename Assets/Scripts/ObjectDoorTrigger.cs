using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door, plate;

    bool isOpened = false;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (!isOpened && col.GetComponent<Collider>().tag == "colObject")
        {
            isOpened = true;
            door.transform.position += new Vector3(20,0,0);
            plate.transform.position -= new Vector3(0,.05F,0);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (isOpened)
        {
            isOpened = false;
            door.transform.position -= new Vector3(20,0,0);
            plate.transform.position += new Vector3(0,.05F,0);
        }
    }
}
