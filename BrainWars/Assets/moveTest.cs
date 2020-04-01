using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTest : MonoBehaviour
{
    public Transform player;


    void moveScript()
    {
        if (Input.GetKeyDown("w"))
        {
            
            player.position += new Vector3(5, 0, 0);
            Debug.Log("Działa");
        }
    }

   
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveScript();
    }
}
