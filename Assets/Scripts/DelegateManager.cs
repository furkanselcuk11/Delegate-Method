using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateManager : MonoBehaviour
{
    public delegate void OnPlayerAttack();  // Delegate ismi
    public static event OnPlayerAttack EventPlayerAttack;   // Delegate event (method toplama) -- di�er scriptler �zerinden olaylar� dinler ve �al��t�r�r 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventPlayerAttack != null)
            {
                // E�er EventPlayerAttack bo� de�ilse �al��t�r
                EventPlayerAttack();    // Mouse tu�una bas�ld���nda event �al���r
            }            
        }
    }
}
