using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitRefresh : MonoBehaviour
{
    private PlayerPos playerPos;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerPos>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerPos.ResetToCheckpoint();
        }
    }
}
