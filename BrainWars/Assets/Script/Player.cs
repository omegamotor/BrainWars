using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int fullShield = 100;
    public int currentShieldStatus;
    public int armyCount = 2;
    public ShieldBarScript shieldbar;

    // Start is called before the first frame update
    public GameObject myPrefab;
    public GameObject memory;

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
        
        
        if (Input.GetMouseButtonDown(0))
        {

            InvokeRepeating("SendWarrior", 1, 1);
            
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

    void SendWarrior()
    {
        if(armyCount > 0)
        {
            Vector3 place = memory.transform.position;
            Instantiate(myPrefab, place, Quaternion.identity);
            --armyCount;
        }
        else
        {
            CancelInvoke("SendWarrior");
        }
        

    }

    
    


}
