using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public string monsterName;
    public int hp;
    public int attack;
    public int defense;
    public int speed;
    public bool isMagic;
    public int experience;
    public int difficulty;

    public Monster(string monsterName, int hp, int attack, int defense, int speed, bool isMagic, int experience, int difficulty){
        this.monsterName = monsterName;
        this.hp = hp;
        this.attack = attack;
        this.defense = defense;
        this.speed = speed;
        this.isMagic = isMagic;
        this.experience = experience;
        this.difficulty = difficulty;
    }

    public Monster(Monster monster){
        this.monsterName = monster.monsterName;
        this.hp = monster.hp;
        this.attack = monster.attack;
        this.defense = monster.defense;
        this.speed = monster.speed;
        this.isMagic = monster.isMagic;
        this.experience = monster.experience;
        this.difficulty = monster.difficulty;
    }

    public string monsterAttackType(){
        if(this.isMagic){
            return "MAGIC";
        }
        else{
            return "PHYSICAL";
        }
    }
}
