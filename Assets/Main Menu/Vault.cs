using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vault : MonoBehaviour
{
    public void GoToVaultMenu()
    {
        SceneManager.LoadScene("Menu_Vault");
    }
}
