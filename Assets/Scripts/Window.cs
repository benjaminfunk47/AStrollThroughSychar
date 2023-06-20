using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Window : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        if (pointerEventData.pointerEnter != null){
            if(pointerEventData.pointerEnter.tag == "Item"){
                DroppedItem di = pointerEventData.pointerEnter.GetComponentInParent<DroppedItem>();
                string itemStats = "";
                string itemName = "";
                string itemSlot;
                //string isMagic;
                string hp;
                string attack;
                string defense;
                string speed;
                string luck;
                switch(di.rarity){
                    case "Common":
                        itemName += "<b><color=#666666>Common</color>\n" + di.itemName + "</b>";
                        break;
                    case "Uncommon":
                        itemName += "<b><color=#0984FF>Uncommon</color>\n" + di.itemName + "</b>";
                        break;
                    case "Relic":
                        itemName += "<b><color=#7E53FF>Relic</color>\n" + di.itemName + "</b>";
                        break;
                    case "Mythical":
                        itemName += "<b><color=#FF0095>Mythical</color>\n" + di.itemName + "</b>";
                        break;
                    case "Legendary":
                        itemName += "<b><color=#DB0200>Legendary</color>\n" + di.itemName + "</b>";
                        break;
                    case "Divine":
                        itemName += "<b><color=#FFD700>Divine</color>\n" + di.itemName + "</b>";
                        break;
                }
                itemSlot = "Type: " + di.itemSlot;
                if(di.hpStat > 0){
                    hp = "HP: <color=#00E710>+" + di.hpStat + "</color>";
                }
                else{
                    hp = "HP: 0";
                }
                if(di.attackStat > 0){
                    attack = "Attack: <color=#00E710>+" + di.attackStat + "</color>";
                }
                else{
                    attack = "Attack: 0";
                }
                if(di.defenseStat > 0){
                    defense = "Defense: <color=#00E710>+" + di.defenseStat + "</color>";
                }
                else{
                    defense = "Defense: 0";
                }
                if(di.speedStat > 0){
                    speed = "Speed: <color=#00E710>+" + di.speedStat + "</color>";
                }
                else{
                    speed = "Speed: 0";
                }
                if(di.luckStat > 0){
                    luck = "Luck: <color=#00E710>+" + di.luckStat + "</color>";
                }
                else{
                    luck = "Luck: 0";
                }
                itemStats += itemName + "\n" + itemSlot + "\n" + hp + "\n" + attack + "\n" + defense + "\n" + speed + "\n" + luck;
                Tooltip.ShowTooltipStatic(itemStats);
            }
            else{
                switch(pointerEventData.pointerEnter.name){
                    case "HPText":
                        Tooltip.ShowTooltipStatic("Total health points");
                        //Debug.Log("HP");
                        break;
                    case "AttackText":
                        Tooltip.ShowTooltipStatic("Offensive ability");
                        //Debug.Log("Attack");
                        break;
                    case "DefenseText":
                        Tooltip.ShowTooltipStatic("Defensive ability");
                        //Debug.Log("Defense");
                        break;
                    case "SpeedText":
                        Tooltip.ShowTooltipStatic("Quickness & evasion ability");
                        //Debug.Log("Speed");
                        break;
                    case "LuckText":
                        Tooltip.ShowTooltipStatic("Susceptibility to rare drops");
                        //Debug.Log("Luck");
                        break;
                    case "AttributePointsText":
                        Tooltip.ShowTooltipStatic("Points used to upgrade skills");
                        //Debug.Log("Attribute Points");
                        break;
                    case "HPButton":
                    case "AttackButton":
                    case "DefenseButton":
                    case "SpeedButton":
                    case "LuckButton":
                        Tooltip.ShowTooltipStatic("Upgrade");
                        //Debug.Log("Upgrade skill button");
                        break;
                    case "NormalSpeed":
                        Tooltip.ShowTooltipStatic("Set to normal speed");
                        //Debug.Log("Normal speed");
                        break;
                    case "FastForward":
                        Tooltip.ShowTooltipStatic("Set to faster speed");
                        //Debug.Log("Fast forward");
                        break;
                    case "FasterForward":
                        Tooltip.ShowTooltipStatic("Set to fastest speed");
                        //Debug.Log("Faster forward");
                        break;
                }
            }
        }
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        Tooltip.HideTooltipStatic();
    }
}
