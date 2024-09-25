using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Games : MonoBehaviour
{
    public void GoToGamesMenu()
    {
        SceneManager.LoadScene("Menu_Games");
    }
}
