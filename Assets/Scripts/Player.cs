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
        DelegateManager.EventPlayerAttack += Attack;    // Delagate methoddaki tanýmlý event ile birlikte çalýþacak fonksiyonu çaðýrýr
    }
    private void OnDisable()
    {
        DelegateManager.EventPlayerAttack -= Attack;    // Delagate methoddaki tanýmlý event içinden çýkararak çalýþmasýný durdurur
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void Attack()
    {
        transform.DOMoveZ(position, duration, true).SetLoops(2,LoopType.Yoyo);
    }
}
