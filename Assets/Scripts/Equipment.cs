using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equipment : MonoBehaviour
{
    [SerializeField] private PlayerHealthBar pHealthBar;

    public Item head;
    public Item chest;
    public Item jewelry;
    public Item gloves;
    public Item legs;
    public Item feet;
    public Item mainhand;
    public Item offhand;
    
    public Text hpStat;
    public Text attStat;
    public Text defStat;
    public Text spdStat;
    public Text luckStat;

    public int hpNum;
    private int attNum;
    private int defNum;
    private int spdNum;
    private int luckNum;

    private void UpdatedStats(){
        hpNum = int.Parse(hpStat.text);
        attNum = int.Parse(attStat.text);
        defNum = int.Parse(defStat.text);
        spdNum = int.Parse(spdStat.text);
        luckNum = int.Parse(luckStat.text);
    }

    private void UpdateStats(){
        pHealthBar.SetPlayerMaxHealth(hpNum);
        hpStat.text = hpNum.ToString();
        attStat.text = attNum.ToString();
        defStat.text = defNum.ToString();
        spdStat.text = spdNum.ToString();
        luckStat.text = luckNum.ToString();
    }

    public void SetEquipment(Item newItem){
        UpdatedStats();
        switch(newItem.itemSlot){
            case "Head":
                head = newItem;
                hpNum += head.hpStat;
                attNum += head.attackStat;
                defNum += head.defenseStat;
                spdNum += head.speedStat;
                luckNum += head.luckStat;
                break;
            case "Chest":
                chest = newItem;
                hpNum += chest.hpStat;
                attNum += chest.attackStat;
                defNum += chest.defenseStat;
                spdNum += chest.speedStat;
                luckNum += chest.luckStat;
                break;
            case "Jewelry":
                jewelry = newItem;
                hpNum += jewelry.hpStat;
                attNum += jewelry.attackStat;
                defNum += jewelry.defenseStat;
                spdNum += jewelry.speedStat;
                luckNum += jewelry.luckStat;
                break;
            case "Gloves":
                gloves = newItem;
                hpNum += gloves.hpStat;
                attNum += gloves.attackStat;
                defNum += gloves.defenseStat;
                spdNum += gloves.speedStat;
                luckNum += gloves.luckStat;
                break;
            case "Mainhand":
                mainhand = newItem;
                hpNum += mainhand.hpStat;
                attNum += mainhand.attackStat;
                defNum += mainhand.defenseStat;
                spdNum += mainhand.speedStat;
                luckNum += mainhand.luckStat;
                break;
            case "Offhand":
                offhand = newItem;
                hpNum += offhand.hpStat;
                attNum += offhand.attackStat;
                defNum += offhand.defenseStat;
                spdNum += offhand.speedStat;
                luckNum += offhand.luckStat;
                break;
            case "Legs":
                legs = newItem;
                hpNum += legs.hpStat;
                attNum += legs.attackStat;
                defNum += legs.defenseStat;
                spdNum += legs.speedStat;
                luckNum += legs.luckStat;
                break;
            case "Feet":
                feet = newItem;
                hpNum += feet.hpStat;
                attNum += feet.attackStat;
                defNum += feet.defenseStat;
                spdNum += feet.speedStat;
                luckNum += feet.luckStat;
                break;
        }
        UpdateStats();
    }

    public void RemoveEquipment(string itemSlot){
        UpdatedStats();
        switch(itemSlot){
            case "Head":
                hpNum -= head.hpStat;
                attNum -= head.attackStat;
                defNum -= head.defenseStat;
                spdNum -= head.speedStat;
                luckNum -= head.luckStat;
                head = null;
                break;
            case "Chest":
                hpNum -= chest.hpStat;
                attNum -= chest.attackStat;
                defNum -= chest.defenseStat;
                spdNum -= chest.speedStat;
                luckNum -= chest.luckStat;
                chest = null;
                break;
            case "Jewelry":
                hpNum -= jewelry.hpStat;
                attNum -= jewelry.attackStat;
                defNum -= jewelry.defenseStat;
                spdNum -= jewelry.speedStat;
                luckNum -= jewelry.luckStat;
                jewelry = null;
                break;
            case "Gloves":
                hpNum -= gloves.hpStat;
                attNum -= gloves.attackStat;
                defNum -= gloves.defenseStat;
                spdNum -= gloves.speedStat;
                luckNum -= gloves.luckStat;
                gloves = null;
                break;
            case "Mainhand":
                hpNum -= mainhand.hpStat;
                attNum -= mainhand.attackStat;
                defNum -= mainhand.defenseStat;
                spdNum -= mainhand.speedStat;
                luckNum -= mainhand.luckStat;
                mainhand = null;
                break;
            case "Offhand":
                hpNum -= offhand.hpStat;
                attNum -= offhand.attackStat;
                defNum -= offhand.defenseStat;
                spdNum -= offhand.speedStat;
                luckNum -= offhand.luckStat;
                offhand = null;
                break;
            case "Legs":
                hpNum -= legs.hpStat;
                attNum -= legs.attackStat;
                defNum -= legs.defenseStat;
                spdNum -= legs.speedStat;
                luckNum -= legs.luckStat;
                legs = null;
                break;
            case "Feet":
                hpNum -= feet.hpStat;
                attNum -= feet.attackStat;
                defNum -= feet.defenseStat;
                spdNum -= feet.speedStat;
                luckNum -= feet.luckStat;
                feet = null;
                break;
        }
        UpdateStats();
    }
}
