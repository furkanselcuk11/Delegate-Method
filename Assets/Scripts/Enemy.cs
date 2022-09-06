using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [Space]
    [Header("Enemy Shake Dotween")]
    [SerializeField] private float duration;    // Shake süresi
    [SerializeField] private float strength;    // Shake gücü
    [SerializeField] private int vibrato;   // Titreþim sayýsý
    [SerializeField] private float randomness;  // Randomluk

    private void OnEnable()
    {
        DelegateManager.EventPlayerAttack += Damage;    // Delagate methoddaki tanımlı event ile birlikte çalışacak fonksiyonu çağırır
    }
    private void OnDisable()
    {
        DelegateManager.EventPlayerAttack -= Damage;    // Delagate methoddaki tanımlı event içinden çıkararak çalışmasını durdurur
    }
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
    private void Damage()
    {
        this.transform.GetComponent<MeshRenderer>().material.DOColor(Color.black, duration).From();          
        this.transform.DOShakeScale(duration, strength, vibrato, randomness);
        health -= 10;
        Debug.Log(this.gameObject.name + " - Health: " + health);
        if (health <= 0)
        {
            Destroy(this.transform.gameObject,0.4f);
        }
    }
}
