using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Characters : MonoBehaviour
{
   public void GoToCharacterMenu()
    {
        SceneManager.LoadScene("Menu_Characters");
    }
}
