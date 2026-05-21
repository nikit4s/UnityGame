using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryManager : MonoBehaviour
{
    public GameObject victoryPanel;

    public void ShowVictory()
    {
        victoryPanel.SetActive(true);

        Time.timeScale = 0f;
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Main Menu");
    }
}