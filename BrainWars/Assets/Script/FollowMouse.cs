using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour
{
    Vector3 mousePosition;
    public float moveSpeed = 0.001f;
    Rigidbody2D rb;
    Vector3 position;

    GameObject player;
    


    //bool start = false;
    public float liveDurationToDeath;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
 
    void Update()
    {

        
        Run();
        Destroy(gameObject, liveDurationToDeath);
    }


    public void Run()
    {
        if(this.tag == "MyWarrior")
        {
            player = GameObject.FindGameObjectWithTag("P1");
        }
        else
        {
            player = GameObject.FindGameObjectWithTag("P2");
        }
        
        mousePosition = player.GetComponent<Transform>().position;
        
        

        Debug.Log("Podano pozycję ");

        //mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        rb.MovePosition(position);
            
    }



    public void Destroy()
    {
        Destroy(this.gameObject);
    }

    

    

    /*
    IEnumerator Wait(int time)
    {
        yield return new WaitForSeconds(time);

    }
    */


    /*
    void Run()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        rb.MovePosition(position);
        //Dodałem start bo taleportowało na środek planszy po włączeniu
        /*start = true;
    }

    else if (start)
    {
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        rb.MovePosition(position);
    }
    }*/



}
