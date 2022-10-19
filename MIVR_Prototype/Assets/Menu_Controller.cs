using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour
{
    public void gameOne()
    {
        SceneManager.LoadScene("Game1");
    }

    public void gameTwo()
    {
        SceneManager.LoadScene("Game2");
    }

    public void gameThree()
    {
        SceneManager.LoadScene("Game3");
    }
}
