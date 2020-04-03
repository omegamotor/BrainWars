using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShieldBarScript : MonoBehaviour
{

    public Slider slider;

    public void SetCooldownTime(int time)
    {
        slider.maxValue = time;
        slider.value = time;
    }

    public void SetShield(int shieldCooldown)
    {
        slider.value = shieldCooldown;
        if (shieldCooldown == 0) InvokeRepeating("ResetShield", 0, 1.0f);

    }

    public void ResetShield()
    {
        slider.value += 10;
        if (slider.value == slider.maxValue) CancelInvoke("ResetShield");

    }

    public bool Ready()
    {
        if (slider.value == slider.maxValue) return true;
        
        else return false;          
    }
    
}
