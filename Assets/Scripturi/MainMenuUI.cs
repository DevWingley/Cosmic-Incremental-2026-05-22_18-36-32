using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject optionsPanel;
    public GameObject playPanel;
    public GameObject mainButtons;

    // PLAY PANEL

    public void OpenPlayPanel()
    {
        playPanel.SetActive(true);
        mainButtons.SetActive(false);
    }

    public void ClosePlayPanel()
    {
        playPanel.SetActive(false);
        mainButtons.SetActive(true);
    }

    // OPTIONS

    public void OpenOptions()
    {
        optionsPanel.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsPanel.SetActive(false);
    }

    // GAME

    public void NewGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void LoadGame()
    {
        Debug.Log("Load Game pressed");
    }

    // QUIT

    public void QuitGame()
    {
        Application.Quit();
    }
}