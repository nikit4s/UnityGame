using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject settingsPanel;

    private bool paused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    public void Pause()
    {
        pausePanel.SetActive(true);

        Time.timeScale = 0f;

        paused = true;
    }

    public void Resume()
    {
        pausePanel.SetActive(false);

        settingsPanel.SetActive(false);

        Time.timeScale = 1f;

        paused = false;
    }

    public void OpenSettings()
    {
        pausePanel.SetActive(false);

        settingsPanel.SetActive(true);
    }

    public void BackToPause()
    {
        settingsPanel.SetActive(false);

        pausePanel.SetActive(true);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Main Menu");
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        Debug.Log("Game Closed");
    }
}