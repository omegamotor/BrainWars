using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateArmy : MonoBehaviour
{
    public int army = 0;
    public float spownTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AddArmy", 1f, spownTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void AddArmy()
    {
        army++;
        Debug.Log(army);
    }

}
