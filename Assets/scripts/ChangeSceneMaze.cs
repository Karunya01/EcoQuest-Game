using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ChangeSceneToMaze : MonoBehaviour
{
     public void GoToMaze()
    {
        SceneManager.LoadScene("MazeScene");
    }
}

