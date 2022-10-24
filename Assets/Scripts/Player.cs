using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    [Space]
    [Header("Player ShaMoveke Dotween")]
    [SerializeField] private float duration;    // Shake süresi
    [SerializeField] private float position;    // Shake gücü   


    private void OnEnable()
    {
        // Delegate Method
        DelegateManager.EventPlayerAttack += Attack;    // Delagate methoddaki tanýmlý event ile birlikte çalýþacak fonksiyonu çaðýrýr
        DelegateManager.EventPlayerAttackDebug += AttackDebug;    // Delagate methoddaki tanýmlý event ile birlikte çalýþacak fonksiyonu çaðýrýr

        // Action Method
        EventManager.ActionPlayerAttack += AttackAction;    // EventManager üzerinden action method ile çalýþma
        EventManager.ActionPlayerAttackDebug += AttackDebugAction;    // EventManager üzerinden action method ile çalýþma
    }
    private void OnDisable()
    {
        // Delegate Method
        DelegateManager.EventPlayerAttack -= Attack;    // Delagate methoddaki tanýmlý event içinden çýkararak çalýþmasýný durdurur
        DelegateManager.EventPlayerAttackDebug -= AttackDebug;    // Delagate methoddaki tanýmlý event içinden çýkararak çalýþmasýný durdurur

        // Action Method
        EventManager.ActionPlayerAttack -= AttackAction;// EventManager üzerinden action method ile çalýþma durdurma
        EventManager.ActionPlayerAttackDebug -= AttackDebugAction;// EventManager üzerinden action method ile çalýþma durdurma
    }

    void Start()
    {
        
    }
    void Update()
    {
       
    }
    private void Attack(int damage)
    {
        // Delegate method event ile çalýþma
        transform.DOMoveZ(position, duration, true).SetLoops(2,LoopType.Yoyo);
        
    }
    private void AttackDebug(int damage)
    {
        // Delegate method event ile çalýþma
        Debug.Log("Attack Damage > " + damage);
    }
    private void AttackAction(int damage)
    {
        // EventManager event Action ile çalýþma
        transform.DOMoveZ(position, duration, true).SetLoops(2, LoopType.Yoyo);

    }   
    private void AttackDebugAction(int damage)
    {
        // EventManager  event Action ile çalýþma
        Debug.Log("Attack Damage > " + damage);
    }
}
