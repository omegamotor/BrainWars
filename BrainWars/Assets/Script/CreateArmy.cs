using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateArmy : MonoBehaviour
{
    public int army = 0;
    public float spownTime = 2f;
    

    Color newColor;
    public SpriteRenderer border;


    void Start()
    {
        InvokeRepeating("AddArmy", 1f, spownTime);
    }

    void AddArmy()
    {
        army++;
        //Debug.Log(army);
        ChangeColor();

    }


    void ChangeColor()
    {


        if (border.color.a == 255)
        {

            Debug.Log("Border Color: " + border.color);
            border.color = new Color(border.color.r, border.color.g, border.color.b, 0);
        }
        else
        {
            Debug.Log("Border Color: " + border.color);
            border.color = new Color(border.color.r, border.color.g, border.color.b, 255f);
        }   

    }





}
