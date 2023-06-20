using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string characterName;
    public int hp;
    public int attack;
    public int defense;
    public int speed;
    public int luck;
    public string attackType;
    public int experience;
    private int randomDamage;

    public int areaNumber;
    public int areaKillCount;

    public Character(string characterName, int hp, int attack, int defense, int speed, int luck, string attackType, int experience, int areaNumber, int areaKillCount){
        this.characterName = characterName;
        this.hp = hp;
        this.attack = attack;
        this.defense = defense;
        this.speed = speed;
        this.luck = luck;
        this.attackType = attackType;
        this.experience = experience;
        this.areaNumber = areaNumber;
        this.areaKillCount = areaKillCount;
    }

    public int Attack(Monster monster){
        int att = this.attack - (int)((float)monster.defense * 0.5f);
        randomDamage = Random.Range(0, (int)(att / 4));
        att += randomDamage;
        if(att > 0){
            return att;
        }
        else{
            return 0;
        }
    }

    public int takeDamage(Monster monster){
        int def = monster.attack - (int)((float)this.defense * 0.25f);
        if(def > 0){
            randomDamage = Random.Range(0, (int)(def / 4));
        }
        else{
            def = 0;
            randomDamage = Random.Range(0, (int)(monster.attack / 10));
        }
        def += randomDamage;
        if(def >= this.hp){
            return this.hp;
        }
        return def;
    }
}
