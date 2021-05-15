using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasControls : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;

    [SerializeField] private bool isPaused;

    [SerializeField] private bool isSetting;

    private PlayerPos playerPos;

    [SerializeField] private GameObject WinScreenUI;

    [SerializeField] private GameObject SettingScreenUI;

    public bool isCleared;

    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerPos>();
        DeactivateClearedMenu();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace) && !isCleared)
        {
            isPaused = !isPaused;
        }

        if (isSetting && isPaused)
        {
            pauseMenuUI.SetActive(false);
            SettingScreenUI.SetActive(true);
        } else if (isPaused)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            ActivatePauseMenu();
        } else if (isCleared)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            ActivateClearedMenu();
        } else
        {
            Cursor.lockState = CursorLockMode.Locked;
            DeactivatePauseMenu();
        }
    }

    public void ActivatePauseMenu()
    {
        isSetting = false;
        SettingScreenUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
    
    void DeactivatePauseMenu()
    {
        pauseMenuUI.SetActive(false);
        SettingScreenUI.SetActive(false);
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
        Cursor.lockState = CursorLockMode.None;
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
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        playerPos.ResetToBeginning();
        DeactivateClearedMenu();
    }

    public void setting_button()
    {
        isSetting = true;
    }
}
