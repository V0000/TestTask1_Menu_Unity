using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(Color color)
    {
        DataHolder.color = color;
        SceneManager.LoadScene("Level1");
    }

    public void OnRedButtonClick()
    {
        ChangeScene(Color.red);
    }
    public void OnGreenButtonClick()
    {
        ChangeScene(Color.green);
    }

    public void OnMenuButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Exit() 
    { 
        Application.Quit(); 
    }

}

