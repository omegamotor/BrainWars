using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    Vector3 mousePosition;
    public float moveSpeed = 0.001f;
    Rigidbody2D rb;
    Vector2 position;
    bool start = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Run();
    }


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
        }*/
    }


}
