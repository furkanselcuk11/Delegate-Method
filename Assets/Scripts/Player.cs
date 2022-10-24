using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    [Space]
    [Header("Player ShaMoveke Dotween")]
    [SerializeField] private float duration;    // Shake s�resi
    [SerializeField] private float position;    // Shake g�c�   


    private void OnEnable()
    {
        // Delegate Method
        DelegateManager.EventPlayerAttack += Attack;    // Delagate methoddaki tan�ml� event ile birlikte �al��acak fonksiyonu �a��r�r
        DelegateManager.EventPlayerAttackDebug += AttackDebug;    // Delagate methoddaki tan�ml� event ile birlikte �al��acak fonksiyonu �a��r�r

        // Action Method
        EventManager.ActionPlayerAttack += AttackAction;    // EventManager �zerinden action method ile �al��ma
        EventManager.ActionPlayerAttackDebug += AttackDebugAction;    // EventManager �zerinden action method ile �al��ma
    }
    private void OnDisable()
    {
        // Delegate Method
        DelegateManager.EventPlayerAttack -= Attack;    // Delagate methoddaki tan�ml� event i�inden ��kararak �al��mas�n� durdurur
        DelegateManager.EventPlayerAttackDebug -= AttackDebug;    // Delagate methoddaki tan�ml� event i�inden ��kararak �al��mas�n� durdurur

        // Action Method
        EventManager.ActionPlayerAttack -= AttackAction;// EventManager �zerinden action method ile �al��ma durdurma
        EventManager.ActionPlayerAttackDebug -= AttackDebugAction;// EventManager �zerinden action method ile �al��ma durdurma
    }

    void Start()
    {
        
    }
    void Update()
    {
       
    }
    private void Attack(int damage)
    {
        // Delegate method event ile �al��ma
        transform.DOMoveZ(position, duration, true).SetLoops(2,LoopType.Yoyo);
        
    }
    private void AttackDebug(int damage)
    {
        // Delegate method event ile �al��ma
        Debug.Log("Attack Damage > " + damage);
    }
    private void AttackAction(int damage)
    {
        // EventManager event Action ile �al��ma
        transform.DOMoveZ(position, duration, true).SetLoops(2, LoopType.Yoyo);

    }   
    private void AttackDebugAction(int damage)
    {
        // EventManager  event Action ile �al��ma
        Debug.Log("Attack Damage > " + damage);
    }
}
