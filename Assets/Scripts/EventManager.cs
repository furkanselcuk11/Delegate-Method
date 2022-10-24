using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    //public static event Action ActionPlayerAttack;   //  event (method toplama) -- di�er scriptler �zerinden olaylar� dinler ve �al��t�r�r 
    public static event Action<int> ActionPlayerAttack;   //  event (method toplama) -- di�er scriptler �zerinden olaylar� dinler ve �al��t�r�r 
    public static event Action<int> ActionPlayerAttackDebug;   //  event (method toplama) -- di�er scriptler �zerinden olaylar� dinler ve �al��t�r�r 
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //if (ActionPlayerAttack != null)
            //{
            //    // E�er ActionPlayerAttack bo� de�ilse �al��t�r
            //    ActionPlayerAttack();    // Mouse tu�una bas�ld���nda event �al���r
            //}

            ActionPlayerAttack?.Invoke(10);  // K�sa Yol
        }
        if (Input.GetMouseButtonDown(1))
        {
            //if (ActionPlayerAttackDebug != null)
            //{
            //    // E�er ActionPlayerAttackDebug bo� de�ilse �al��t�r
            //    ActionPlayerAttackDebug(10);    // Mouse tu�una bas�ld���nda event �al���r
            //}

            ActionPlayerAttackDebug?.Invoke(10); // K�sa Yol
        }
    }
}
