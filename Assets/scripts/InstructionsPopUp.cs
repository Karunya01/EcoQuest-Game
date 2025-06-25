using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InstructionsPopUp : MonoBehaviour
{
     public GameObject instructionPanel1;

    void Start()
    {
        // Show instructions on game start
        instructionPanel1.SetActive(true);

        // Pause the game
        Time.timeScale = 0f;
    }

    public void CloseInstructions()
    {
        // Hide the panel and resume game
        instructionPanel1.SetActive(false);
        Time.timeScale = 1f;
    }
}
