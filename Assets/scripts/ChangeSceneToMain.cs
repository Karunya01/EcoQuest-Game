using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ChangeSceneToMain : MonoBehaviour
{
     public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
