using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Wallet : MonoBehaviour
{
    [SerializeField] float money;

    public event Action OnMoneyChanged;

    public static Wallet i {get; private set;}

    private void Awake(){
        i = this;
    }

    public float Money => money;

    public void AddMoney(float amount){
        money += amount;
        OnMoneyChanged?.Invoke();
    }

    public void TakeMoney(float amount){
        money -= amount;
        OnMoneyChanged?.Invoke();
    }
}
