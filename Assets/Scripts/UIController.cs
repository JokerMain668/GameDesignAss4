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

    public void loadLevel2()
    {
        SceneManager.LoadSceneAsync(3, LoadSceneMode.Single);
    }

    public void loadLevel3()
    {
        SceneManager.LoadSceneAsync(4, LoadSceneMode.Single);
    }

    public void loadLevel4()
    {
        SceneManager.LoadSceneAsync(5, LoadSceneMode.Single);
    }
    public void loadLevel5()
    {
        SceneManager.LoadSceneAsync(6, LoadSceneMode.Single);
    }
}
