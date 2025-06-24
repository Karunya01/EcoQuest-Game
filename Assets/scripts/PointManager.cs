using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public static PointManager Instance;
    public GameObject winPanel;

    public Text scoreText;
    private int score = 0;

    private void Awake()
    {
        // Singleton pattern so we can access this from anywhere
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        UpdateScoreText();
        winPanel.SetActive(false);
    }

    public void AddPoint()
    {
        score += 10;
        UpdateScoreText();
        if (score >= 30)
        {
            ShowWinPanel();
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "EcoPoints: " + score.ToString();

    }
    
    private void ShowWinPanel()
    {
        winPanel.SetActive(true);
        //Time.timeScale = 0f; // ⏸ Optional: pause the game
    }
    
}
