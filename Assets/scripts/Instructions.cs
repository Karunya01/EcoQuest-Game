using UnityEngine;

public class Instructions : MonoBehaviour
{
    public GameObject instructionsPanel;
    public void StartGame()
    {
        instructionsPanel.SetActive(false);
        Time.timeScale = 1f; // Resume the game
    }
}
