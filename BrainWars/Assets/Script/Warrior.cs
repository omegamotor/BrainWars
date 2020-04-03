using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{

    public Transform warrior;

    private Vector3 mousePos;
    private Rigidbody2D rb;
    private Vector2 direction;
    private float moveSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {



            
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            Vector2 warrior2D = new Vector2(warrior.position.x, warrior.position.y);

            //Przenieś przedmiot w miejsce gdzie wcisnołem
            //warrior.position = new Vector3(mousePos2D[0], mousePos2D[1], 0);


            ////////////////////////////////////////////////////////////////////////////////////////////////
            //    mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //    direction = (mousePos - transform.position).normalized;
            //    rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);

            //}

         //else
         //{
         //    rb.velocity = Vector2.zero;
         //
         /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }



        
    }
}
