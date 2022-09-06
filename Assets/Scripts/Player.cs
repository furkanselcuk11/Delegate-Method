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
        DelegateManager.EventPlayerAttack += Attack;    // Delagate methoddaki tan�ml� event ile birlikte �al��acak fonksiyonu �a��r�r
    }
    private void OnDisable()
    {
        DelegateManager.EventPlayerAttack -= Attack;    // Delagate methoddaki tan�ml� event i�inden ��kararak �al��mas�n� durdurur
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
