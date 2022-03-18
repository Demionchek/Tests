using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _menuButton;

    private void Start()
    {
        _menuPanel.SetActive(true);
        _menuButton.SetActive(false);
    }

    public void OnMenuButtonPressed()
    {
        _menuPanel.SetActive(true);
        _menuButton.SetActive(false);
        _spawner.StopSpawning();
    }

    public void OnStartButtonPressed() 
    {
        _menuPanel.SetActive(false);
        _menuButton.SetActive(true);
        _spawner.StartSpawning();
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }
}
