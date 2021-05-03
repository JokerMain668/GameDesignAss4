using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasControls : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;

    [SerializeField] private bool isPaused;

    private PlayerPos playerPos;

    [SerializeField] private GameObject WinScreenUI;

    public bool isCleared;

    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerPos>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            ActivatePauseMenu();
        } else
        {
            Cursor.lockState = CursorLockMode.Locked;
            DeactivatePauseMenu();
        }
        if (isCleared)
        {
            Cursor.lockState = CursorLockMode.None;
            ActivateClearedMenu();
        }
    }

    void ActivatePauseMenu()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
    
    void DeactivatePauseMenu()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Resume_Button()
    {
        DeactivatePauseMenu();
        isPaused = !isPaused;
    }

    public void checkpoint_button()
    {
        playerPos.ResetToCheckpoint();
        DeactivatePauseMenu();
    }

    void ActivateClearedMenu()
    {
        WinScreenUI.SetActive(true);
        Time.timeScale = 0f;
    }

    void DeactivateClearedMenu()
    {
        WinScreenUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void exit_button()
    {
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
    }

    public void retry_button()
    {
        playerPos.ResetToBeginning();
        DeactivateClearedMenu();
    }
}
