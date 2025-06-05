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
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
         moneyManager.UpdateMoney(cost);
         Destroy(gameObject);
            
        }

    }
}
