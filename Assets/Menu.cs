using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Playgamelevel1 ()
    {
        SceneManager.LoadScene("Dikke");
    }
    public void Playgamelevel2()
    {
        SceneManager.LoadScene("...");
    }
    public void Playgamelevel3()
    {
        SceneManager.LoadScene("....");
    }
    public void Quit ()
    {
        Debug.Log("Buik");
        Application.Quit();
    }
}
