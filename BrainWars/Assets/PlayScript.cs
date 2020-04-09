﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{

    public void Play()
    {
        Debug.Log("Exit");
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

}
