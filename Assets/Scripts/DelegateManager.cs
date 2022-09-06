using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateManager : MonoBehaviour
{
    public delegate void OnPlayerAttack();  // Delegate ismi
    public static event OnPlayerAttack EventPlayerAttack;   // Delegate event (method toplama) -- diðer scriptler üzerinden olaylarý dinler ve çalýþtýrýr 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventPlayerAttack != null)
            {
                // Eðer EventPlayerAttack boþ deðilse çalýþtýr
                EventPlayerAttack();    // Mouse tuþuna basýldýðýnda event çalýþýr
            }            
        }
    }
}
