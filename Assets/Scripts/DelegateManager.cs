using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateManager : MonoBehaviour
{
    //public delegate void OnPlayerAttack();  // Delegate ismi
    public delegate void OnPlayerAttack(int damage);  // Delegate ismi deðer alan

    public static event OnPlayerAttack EventPlayerAttack;   // Delegate event (method toplama) -- diðer scriptler üzerinden olaylarý dinler ve çalýþtýrýr 
    public static event OnPlayerAttack EventPlayerAttackDebug;   // Delegate event (method toplama) -- diðer scriptler üzerinden olaylarý dinler ve çalýþtýrýr 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //if (EventPlayerAttack != null)
            //{
            //    // Eðer EventPlayerAttack boþ deðilse çalýþtýr
            //    EventPlayerAttack(10);    // Mouse tuþuna basýldýðýnda event çalýþýr
            //}

            EventPlayerAttack?.Invoke(10);  // Kýsa Yol
        }
        if (Input.GetMouseButtonDown(1))
        {
            //if (EventPlayerAttackDebug != null)
            //{
            //    // Eðer EventPlayerAttackDebug boþ deðilse çalýþtýr
            //    EventPlayerAttackDebug(10);    // Mouse tuþuna basýldýðýnda event çalýþýr
            //}

            EventPlayerAttackDebug?.Invoke(10); // Kýsa Yol
        }
    }
}
