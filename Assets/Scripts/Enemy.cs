using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private int damageValue = 10;
    [Space]
    [Header("Enemy Shake Dotween")]
    [SerializeField] private float duration;    // Shake süresi
    [SerializeField] private float strength;    // Shake gücü
    [SerializeField] private int vibrato;   // Titreþim sayýsý
    [SerializeField] private float randomness;  // Randomluk

    private void OnEnable()
    {
        DelegateManager.EventPlayerAttack += Damage;    // Delagate methoddaki tanımlı event ile birlikte çalışacak fonksiyonu çağırır

        EventManager.ActionPlayerAttack += DamageAction;    // EventManager üzerinden action method ile çalışma
    }
    private void OnDisable()
    {
        DelegateManager.EventPlayerAttack -= Damage;    // Delagate methoddaki tanımlı event içinden çıkararak çalışmasını durdurur

        EventManager.ActionPlayerAttack -= DamageAction;    // EventManager üzerinden action method ile çalışma
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void Damage(int damage)
    {
        // Delegate method event ile çalışma
        this.transform.GetComponent<MeshRenderer>().material.DOColor(Color.black, duration).From();          
        this.transform.DOShakeScale(duration, strength, vibrato, randomness);
        damage = this.damageValue;  // Düşmanın alacağı damage tanımlı olan damage değeri kadar azalır
        health -= damage;
        Debug.Log(this.gameObject.name + " - Health: " + health);
        if (health <= 0)
        {
            Destroy(this.transform.gameObject,0.4f);
        }
    }
    private void DamageAction(int damage)
    {
        // EventManager event Action ile çalışma
        this.transform.GetComponent<MeshRenderer>().material.DOColor(Color.black, duration).From();
        this.transform.DOShakeScale(duration, strength, vibrato, randomness);
        damage = this.damageValue;  // Düşmanın alacağı damage tanımlı olan damage değeri kadar azalır
        health -= damage;
        Debug.Log(this.gameObject.name + " - Health: " + health);
        if (health <= 0)
        {
            Destroy(this.transform.gameObject, 0.4f);
        }
    }
}
