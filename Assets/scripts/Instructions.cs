using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Instructions : MonoBehaviour
{
    public GameObject instructionPanel;

    void Start()
    {
        // Show instructions on game start
        instructionPanel.SetActive(true);

        // Pause the game
        Time.timeScale = 0f;
    }

    public void CloseInstructions()
    {
        // Hide the panel and resume game
        instructionPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
