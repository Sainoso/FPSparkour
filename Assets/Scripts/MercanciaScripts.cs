using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MercanciaScripts : MonoBehaviour
{
    public float cost;
    public MoneyManager moneyManager;

    private void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }
    
    public void onInteraction(){
        moneyManager.UpdateMoney(-cost);
        Destroy(gameObject);
    }
}
