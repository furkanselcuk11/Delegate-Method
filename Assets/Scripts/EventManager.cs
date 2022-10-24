using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    //public static event Action ActionPlayerAttack;   //  event (method toplama) -- diðer scriptler üzerinden olaylarý dinler ve çalýþtýrýr 
    public static event Action<int> ActionPlayerAttack;   //  event (method toplama) -- diðer scriptler üzerinden olaylarý dinler ve çalýþtýrýr 
    public static event Action<int> ActionPlayerAttackDebug;   //  event (method toplama) -- diðer scriptler üzerinden olaylarý dinler ve çalýþtýrýr 
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //if (ActionPlayerAttack != null)
            //{
            //    // Eðer ActionPlayerAttack boþ deðilse çalýþtýr
            //    ActionPlayerAttack();    // Mouse tuþuna basýldýðýnda event çalýþýr
            //}

            ActionPlayerAttack?.Invoke(10);  // Kýsa Yol
        }
        if (Input.GetMouseButtonDown(1))
        {
            //if (ActionPlayerAttackDebug != null)
            //{
            //    // Eðer ActionPlayerAttackDebug boþ deðilse çalýþtýr
            //    ActionPlayerAttackDebug(10);    // Mouse tuþuna basýldýðýnda event çalýþýr
            //}

            ActionPlayerAttackDebug?.Invoke(10); // Kýsa Yol
        }
    }
}
