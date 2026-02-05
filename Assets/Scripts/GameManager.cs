using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int lives = 3;
    public TextMeshProUGUI livesText;

    private AppleTree appleTree;

    void Start()
    {
        appleTree = FindFirstObjectByType<AppleTree>();
        UpdateLivesText();
    }

    public void LoseLife()
    {
        lives--;
        UpdateLivesText();

        if (lives <= 0)
        {
            GameOver();
        }
    }

    void UpdateLivesText()
    {
        if (livesText != null)
        {
            livesText.text = "Lives: " + lives;
        }
    }

    void GameOver()
    {
        Debug.Log("GAME OVER");

        if (appleTree != null)
        {
            appleTree.StopSpawning();
        }

        Time.timeScale = 0f;
    }
}