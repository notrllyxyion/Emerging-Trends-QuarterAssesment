using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutUs : MonoBehaviour
{
    public void GoToAboutUsMenu()
    {
        SceneManager.LoadScene("Menu_Aboutus");
    }
}
