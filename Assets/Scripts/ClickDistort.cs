using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class ClickDistort : MonoBehaviour
{
    Camera cam;
    GameObject player;
    private PostProcessVolume volume;
    private LensDistortion LD;
    private GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        player = GameObject.FindGameObjectWithTag("Player");
        effect = GameObject.FindGameObjectWithTag("Effect");
        volume = effect.GetComponent<PostProcessVolume>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "MoveableObject")
                {
                    volume.profile.TryGetSettings(out LD);
                    //Debug.Log("1");
                    LD.intensity.value += 10f;
                }
            }
        }
    }
}
