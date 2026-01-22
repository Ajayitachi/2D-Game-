using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // PLAY button
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene"); // change to your level scene name
    }

    // OPTIONS button
    public void OpenOptions()
    {
        Debug.Log("Options Clicked");
        // later you can open options panel here
    }

    // QUIT button
    public void QuitGame()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
