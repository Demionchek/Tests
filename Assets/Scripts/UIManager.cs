using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _menuButton;

    public delegate void Click();
    public static event Click MenuClick;
    public static event Click StartClick;

    private void Start()
    {
        _menuPanel.SetActive(true);
        _menuButton.SetActive(false);
    }

    public void OnMenuButtonPressed()
    {
        _menuPanel.SetActive(true);
        _menuButton.SetActive(false);
        if (MenuClick != null)
        {
           MenuClick();
        }
    }

    public void OnStartButtonPressed() 
    {
        _menuPanel.SetActive(false);
        _menuButton.SetActive(true);
        if (StartClick != null)
        {
            StartClick();
        }
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }
}
