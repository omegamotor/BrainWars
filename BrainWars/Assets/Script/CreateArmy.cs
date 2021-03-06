﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateArmy : MonoBehaviour
{
    public int maxArmy = 5;
    public int army = 0;
    public float spownTime = 2f;
    private bool shoot = false;
    public GameObject myWarrior;
    public GameObject enemyWarrior;


    public SpriteRenderer pole;

    public GameStatus status;
 


    public SpriteRenderer border;
    public SpriteRenderer memory;

    public int controlLevel = 10;

    //Uruchom produkcję wojowników
    void Start()
    {
        StartAddArmy();
        CheckTeam();

        ChangeStateColor();

    }

    //Po wciśnięciu myszki zacznij wysyłanie wojowników i zablokuj kolejne wysyłania
    private void Update()
    {

        //if (Input.GetMouseButtonDown(0) && !shoot && this.tag=="EnemyMemory")
        if (Input.GetKey("m") && !shoot && this.tag=="EnemyMemory")
        {
            InvokeRepeating("SendWarrior", 0.1f, 1);
            shoot = true;
        }

        if (Input.GetKey("c") && !shoot && this.tag == "MyMemory")
        {
            InvokeRepeating("SendWarrior", 0.1f, 1);
            shoot = true;
        }


        if (Input.GetKeyDown("q"))
        {
            ChangeStateColor();

        }




    }

    //Dodaj kolejnego wojownika do bazy i  zmień kolor obramowania
    void AddArmy()
    {
        if(maxArmy > army)
        {
            army++;
            //Debug.Log(army);
            ChangeColor();
        }
        
    }

    //Zatrzymaj produkcję wojsk
    public void StopAddArmy()
    {
        CancelInvoke("AddArmy");
    }
    //Wznów produkcję wojsk
    public void StartAddArmy()
    {
        InvokeRepeating("AddArmy", 1f, spownTime);
    }

    //Zmień kolor obramowania na przezroczysty/normalny
    void ChangeColor()
    {      
            if (border.color.a == 255)
            {
                //Debug.Log("Border Color: " + border.color);
                border.color = new Color(border.color.r, border.color.g, border.color.b, 0);
            }
            else
            {
                //Debug.Log("Border Color: " + border.color);
                border.color = new Color(border.color.r, border.color.g, border.color.b, 255f);
            }
               
    }

    //Wysyłaj kolejnych wojowników dopuki są w wspomnieniu
    //Każdy co sekundę, zatrzymaj produkcję dopuki wszyscy nie wyjdą
    //Po wysłaniu wszystkich wznów produkcję i wyłącz blokadę na strzelanie
    void SendWarrior()
    {
        if (army > 0)
        {
            Vector3 place = transform.position;

            if (this.tag == "MyMemory")
            {
                Instantiate(myWarrior, place, Quaternion.identity);
            }
            else if (this.tag == "EnemyMemory")
            {
                Instantiate(enemyWarrior, place, Quaternion.identity);
            }


            army -= 1;
            StopAddArmy();
        }
        else
        {
            CancelInvoke("SendWarrior");
            shoot = false;
            StartAddArmy();
        }

    }



    public void CheckTeam()
    {
        if(this.tag == "EnemyMemory")
        {
            //Debug.Log("Enemy");
            memory.color = new Color(200, 0, 0, memory.color.a);
        }

        else if (this.tag == "MyMemory")
        {
            //Debug.Log("Mem");
            memory.color = new Color(0, 255, 65, memory.color.a);
        }


    }

    public void ChangeTeam()
    {
        if (this.tag == "EnemyMemory")
        {
            this.tag = "MyMemory";
            

        }
        else
        {
            this.tag = "EnemyMemory";
            
        }
        
        CheckTeam();
        ChangeStateColor();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
              
        if (((collision.gameObject.tag == "MyWarrior") && (this.tag == "EnemyMemory")) ||
            (collision.gameObject.tag == "EnemyWarrior") && (this.tag == "MyMemory"))
        {
            collision.gameObject.GetComponent<FollowMouse>().Destroy();           
            controlLevel -= 1;                   
            if(controlLevel == 0)
            {
                ChangeTeam();
                controlLevel = 10;
            }          
        }
        
    }









    public void ChangeStateColor()
    {
        if(this.tag == "MyMemory")
        {           
            pole.sortingLayerName = "blue";      

        }
        else if (this.tag == "EnemyMemory")
        {
            pole.sortingLayerName = "ukryj";
        }
    }


}
