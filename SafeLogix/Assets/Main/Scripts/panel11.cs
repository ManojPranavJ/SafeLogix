using UnityEngine;

public class panel11 : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject loginpage;
    public GameObject registerpage;

    private void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
        loginpage.SetActive(false);
        registerpage.SetActive(false);
        Invoke("ShowOptionsMenu", 2f); // Schedule ShowOptionsMenu to be called after 2 seconds
    }

    public void ShowOptionsMenu()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
        loginpage.SetActive(false);
        registerpage.SetActive(false);
    }

    public void Showloginpage()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(false);
        loginpage.SetActive(true);
        registerpage.SetActive(false);
    }

    public void Showregisterpage()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(false);
        loginpage.SetActive(false);
        registerpage.SetActive(true);
    }
}
