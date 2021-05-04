using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountPins : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField]
    GameObject door2;

    // Update is called once per frame
    void Update()
    {
        
    	var pins = GameObject.FindGameObjectsWithTag("Pin");
		
	int counter = 0;	

	foreach (var pin in pins)
	{
        if (pin.transform.up.y < 0.97)
	    { 
		counter++;           
            }
	}
	
	if (counter == 10)
	{
		door2.transform.position += new Vector3 (0, 13, 0);
		Destroy (gameObject);
	}
    }


}
