using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void LoadButton()
    {
        SceneManager.LoadScene("CustomizeCoach");
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }
}
