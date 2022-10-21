using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateManager : MonoBehaviour
{
    //public delegate void OnPlayerAttack();  // Delegate ismi
    public delegate void OnPlayerAttack(int damage);  // Delegate ismi de�er alan

    public static event OnPlayerAttack EventPlayerAttack;   // Delegate event (method toplama) -- di�er scriptler �zerinden olaylar� dinler ve �al��t�r�r 
    public static event OnPlayerAttack EventPlayerAttackDebug;   // Delegate event (method toplama) -- di�er scriptler �zerinden olaylar� dinler ve �al��t�r�r 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //if (EventPlayerAttack != null)
            //{
            //    // E�er EventPlayerAttack bo� de�ilse �al��t�r
            //    EventPlayerAttack(10);    // Mouse tu�una bas�ld���nda event �al���r
            //}

            EventPlayerAttack?.Invoke(10);  // K�sa Yol
        }
        if (Input.GetMouseButtonDown(1))
        {
            //if (EventPlayerAttackDebug != null)
            //{
            //    // E�er EventPlayerAttackDebug bo� de�ilse �al��t�r
            //    EventPlayerAttackDebug(10);    // Mouse tu�una bas�ld���nda event �al���r
            //}

            EventPlayerAttackDebug?.Invoke(10); // K�sa Yol
        }
    }
}
