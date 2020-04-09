using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            winPlayer.text = "Gracz Niebieski";
            endScreen.SetActive(true);

            
            InvokeRepeating("Intro", 1f, 5f);
        }
        else if (mem.Length == 0)
        {
            winPlayer.text = "Gracz Czerwony";
            winPlayer.color = new Color(192f,41f,41f,255f);
            endScreen.SetActive(true);
            
            InvokeRepeating("Intro", 1f, 2f);
            
        }



        void Intro()
        {
            endScreen.SetActive(true);
            SceneManager.LoadScene("intro");
        }




    }
}
