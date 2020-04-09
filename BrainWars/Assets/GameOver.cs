using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public void Retry()
    {
        Debug.Log("Retry");
        SceneManager.LoadScene("Game");
        
    }
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
        
    }


}
