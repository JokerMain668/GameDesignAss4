using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadTutLvl()
    {
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Single);
    }

    public void loadLevel1()
    {
        SceneManager.LoadSceneAsync(2, LoadSceneMode.Single);
    }
}
