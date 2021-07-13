using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() // Load's the game scene
    {
        SceneManager.LoadScene("TestEnvironment");
    }

    public void Credits() // Load's the credits scene
    {
        SceneManager.LoadScene("CreditsMenu");
    }

    public void Quit() // Stops the application
    {
        Application.Quit();
    }
}
