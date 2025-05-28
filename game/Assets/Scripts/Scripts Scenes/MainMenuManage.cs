using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private string nameOfLevelGame;
    [SerializeField] private GameObject panelMainMenu;
    [SerializeField] private GameObject panelOptions;

    public void Play()
    {
        SceneManager.LoadScene(nameOfLevelGame);
    }
    public void OpenOptions()
    {
        panelMainMenu.SetActive(false);
        panelOptions.SetActive(true);
    }
    public void CloseOptions()
    {
        panelMainMenu.SetActive(true);
        panelOptions.SetActive(false);
    }
    
    public void ExitGame()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }

}
