using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateArmy : MonoBehaviour
{
    public int army = 0;
    public float spownTime = 2f;
    private bool shoot = false;
    public GameObject warrior;


    public SpriteRenderer border;
    

    
    //Uruchom produkcję wojowników
    void Start()
    {
        StartAddArmy();
        
    }

    //Po wciśnięciu myszki zacznij wysyłanie wojowników i zablokuj kolejne wysyłania
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !shoot)
        {
            InvokeRepeating("SendWarrior", 0.1f, 1);
            shoot = true;
        }
    }

    //Dodaj kolejnego wojownika do bazy i  zmień kolor obramowania
    void AddArmy()
    {
        army++;
        //Debug.Log(army);
        ChangeColor();
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
            Instantiate(warrior, place, Quaternion.identity);
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



}
