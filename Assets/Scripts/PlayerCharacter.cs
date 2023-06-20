using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public Item[] inventory = new Item[24];
    public Item headSlot;
    public Item chestSlot;
    public Item gloveSlot;
    public Item legsSlot;
    public Item feetSlot;
    public Item weaponSlot;
    public Item offHandSlot;

    public Character playerCharacter; //= new Character("Name", 10, 10, 10, 10, 10, "PHYSICAL", 0, 0, 0);

    void Awake(){
        DontDestroyOnLoad(this);
    }
}
