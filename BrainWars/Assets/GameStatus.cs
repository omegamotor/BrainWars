using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEditor;
using System;

public class GameStatus : MonoBehaviour
{
    public Text p1;
    public Text p2;
    public Text winPlayer;

    public GameObject endScreen; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Punkt();
    }


    public void Punkt()
    {
        var mem = GameObject.FindGameObjectsWithTag("MyMemory");

        p1.text = mem.Length + " - Niebiescy";
        p2.text = 12 - (mem.Length) + " - Czerwoni";

        if(mem.Length == 12)
        {
            //winPlayer.text = "Gracz Niebieski";

            //SaveWinPlayerU("1");

            SceneManager.LoadScene("Game_Over");


        }
        else if (mem.Length == 0)
        {
            //winPlayer.text = "Gracz Czerwony";
            //winPlayer.color = new Color(192f,41f,41f,255f);

            //SaveWinPlayerU("2");



           SceneManager.LoadScene("Game_Over");


        }     

    }
    /*void Intro()
    {
        endScreen.SetActive(true);
        SceneManager.LoadScene("intro");
    }*/

    
    public void SaveWinPlayer(string p)
    {
        string path = "Assets/Resources/wygrywa.txt";


        File.WriteAllText(path, p);

        Debug.Log(p);
        Debug.Log("\n\n\n");
        Debug.Log(File.ReadAllText("Assets/Resources/wygrywa.txt"));
    }

    public void SaveWinPlayerU(string p)
    {
        string path = "Assets/Resources/wygrywa.txt";
        //File.WriteAllText(path, String.Empty);

        StreamWriter writer = new StreamWriter(path, true);
        writer.Write(p);
        writer.Close();

        StreamReader reader = new StreamReader(path);

        Debug.Log(p);
        Debug.Log("\n\n\n");
        Debug.Log(reader.ReadLine());
        reader.Close();
    }





}
