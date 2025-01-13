using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI CoinText, OrbText;
    public Image[] Items;
    public static GameManager gameManager;
    public int orbs = 0, coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.gameManager != null && GameManager.gameManager != this){
        Destroy(gameObject);
        }
        else{
            GameManager.gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
 public void OrbCollected(){
    orbs++;
    OrbText.text = "Orbs: " + orbs;
 }
public void CoinCollected(int i){
    coins+= i;
    CoinText.text = "Coins: " + coins;
}
public void ItemCollected(Sprite sprite, int id){
    Items[id].sprite = sprite;
}
}
