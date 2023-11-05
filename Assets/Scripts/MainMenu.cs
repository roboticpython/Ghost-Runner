using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame ()
    {
        SceneManager.LoadScene("Store");   
    }
    public void GameOptions () 
    {
        SceneManager.LoadScene("Optons");
    }
    public void Return()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void scenc1 ()
    {
        SceneManager.LoadScene("Game1");
    }
    public void scenc2()
    {
        SceneManager.LoadScene("Game2");
    }
    public void scenc3()
    {
        SceneManager.LoadScene("Game3");
    }
    public void scenc4()
    {
        SceneManager.LoadScene("game4");
    }
    public void glitch()
    {
        SceneManager.LoadScene("glitch");
    }
}
