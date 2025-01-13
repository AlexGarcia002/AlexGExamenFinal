using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour, ICollectable
{
    public void OnCollected(){
        GameManager.gameManager.CoinCollected(10);
        Destroy(gameObject);
    }
}
