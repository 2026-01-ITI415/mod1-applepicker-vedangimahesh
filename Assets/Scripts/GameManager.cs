using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int lives = 3;
    public TextMeshProUGUI livesText;

    void Start()
    {
        UpdateUI();
    }

    public void LoseLife()
    {
        lives--;
        UpdateUI();

        if (lives <= 0)
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0f; // freeze game
        }
    }

    void UpdateUI()
    {
        if (livesText != null)
            livesText.text = "Lives: " + lives;
    }
}