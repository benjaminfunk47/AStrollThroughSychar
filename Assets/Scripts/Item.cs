using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string itemName;
    public int hpStat;
    public int attackStat;
    public int defenseStat;
    public int speedStat;
    public int luckStat;
    public bool isMagic;
    public string rarity;
    public string itemSlot;

    public Item(string itemName, int hpStat, int attackStat, int defenseStat, int speedStat, int luckStat, bool isMagic, string rarity, string itemSlot){
        this.itemName = itemName;
        this.hpStat = hpStat;
        this.attackStat = attackStat;
        this.defenseStat = defenseStat;
        this.speedStat = speedStat;
        this.luckStat = luckStat;
        this.isMagic = isMagic;
        this.rarity = rarity;
        this.itemSlot = itemSlot;
    }

    public Item(Item item){
        this.itemName = item.itemName;
        this.hpStat = item.hpStat;
        this.attackStat = item.attackStat;
        this.defenseStat = item.defenseStat;
        this.speedStat = item.speedStat;
        this.luckStat = item.luckStat;
        this.isMagic = item.isMagic;
        this.rarity = item.rarity;
        this.itemSlot = item.itemSlot;
    }

    
}
