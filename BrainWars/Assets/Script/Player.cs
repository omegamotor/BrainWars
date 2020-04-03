using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int fullShield = 100;
    public int currentShieldStatus;
    
    ////////////////////////
    public GameObject memory;
    private CreateArmy memoryArmy;

    ////////////////////////


    public ShieldBarScript shieldbar;

    // Start is called before the first frame update
    public GameObject myPrefab;
 

    void Start()
    {
        currentShieldStatus = fullShield;
        shieldbar.SetCooldownTime(fullShield);              
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UseShield();
        }
              
    }

    void UseShield()
    {
        if(shieldbar.Ready())
        {
            currentShieldStatus = 0;
            shieldbar.SetShield(currentShieldStatus);
        }
    }

}
