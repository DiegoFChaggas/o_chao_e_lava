using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverPanel;
    [SerializeField] private string nameOfLevelGame;
    [SerializeField] private GameObject restartLevel;
    [SerializeField] private GameObject goToMainMenu;
    public Button menuButton;

    [Tooltip("Nome da cena do menu principal")]
    public string mainMenuSceneName = "MenuPrincipal";


    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
        //Time.timeScale = 0f; // pausa o jogo
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(nameOfLevelGame);
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenuSceneName);
    }
}
