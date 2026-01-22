using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Score")]
    public int score = 0;
    public TextMeshProUGUI scoreText;

    [Header("UI Panels")]
    public GameObject gameOverPanel; // Assign your GameOverPanel here

    private bool isGameOver = false;

    void Awake()
    {
        // Singleton setup
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        // Hide Game Over panel at start
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);

        UpdateScore();
        Time.timeScale = 1f; // Make sure game is not paused
    }

    // Called by coins or other point events
    public void AddScore(int value)
    {
        if (isGameOver) return;

        score += value;
        UpdateScore();
    }

    void UpdateScore()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }

    // Called when player hits flag or dies
    public void GameOver()
    {
        isGameOver = true;

        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);

        Time.timeScale = 0f; // Pause game
    }

    // Button callback for Restart
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Button callback for Home
    public void GoHome()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0); // Make scene 0 your Home/Main menu
    }
}
