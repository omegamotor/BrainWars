using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    public Transform p1;
    Vector3 pos;

    
    void Update()
    {
        pos = p1.position;
        if ((Input.GetKey("w")&& this.tag == "P1") || (Input.GetKey("p") && this.tag == "P2"))
        {           
            p1.position = new Vector3(p1.position.x, p1.position.y + 0.03f, 0f);
        }
        else if ((Input.GetKey("s") && this.tag == "P1") || (Input.GetKey(";") && this.tag == "P2"))
        {
            p1.position = new Vector3(p1.position.x, p1.position.y - 0.03f, 0f);
        }

        if ((Input.GetKey("d") && this.tag == "P1") || (Input.GetKey("'") && this.tag == "P2"))
        {
            p1.position = new Vector3(p1.position.x + 0.03f, p1.position.y, 0f);
        }
        else if ((Input.GetKey("a") && this.tag == "P1") || (Input.GetKey("l") && this.tag == "P2"))
        {
            p1.position = new Vector3(p1.position.x - 0.03f, p1.position.y, 0f);
            
        }






        if (Input.GetKey("q"))
        {
            Debug.Log("Podano pozycję " + pos.x);
        }

        

    }


    




}
