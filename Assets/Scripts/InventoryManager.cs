using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public InventorySlot[] allSlots = new InventorySlot[24];
    public int slotsLeft;
    public int firstSlotOpenIndex;
    public InventorySlot firstSlotOpen;
    public GameObject nextSlot;
    public Item spawnedItem;
    public Toggle commonToggle;
    public Toggle uncommonToggle;
    public Toggle relicToggle;
    public Toggle mythicalToggle;
    public Toggle legendaryToggle;
    public Toggle divineToggle;

    private void Awake(){
        allSlots = GetComponentsInChildren<InventorySlot>();
        slotsLeft = 0;
        firstSlotOpenIndex = 0;
    }

    private void updateSlotsLeft(){
        slotsLeft = 0;
        for(int slot = allSlots.Length - 1; slot >= 0; slot--){
            if(allSlots[slot].itemInSlot == null){
                slotsLeft += 1;
                firstSlotOpenIndex = slot;
            }
        }
    }

    public bool SpawnItem(Character player, Monster monster){
        int luck = player.luck;
        int difficultyRating = monster.difficulty;
        int area = player.areaNumber;
        int randItemIndex;
        string prefabStringNeeded;

        if(difficultyRating == 3){
            randItemIndex = Random.Range(0, 5);
            switch(area){
                case 0:
                    spawnedItem = ItemPool.areaOneBossItems[randItemIndex];
                    break;
                case 1:
                    spawnedItem = ItemPool.areaTwoBossItems[randItemIndex];
                    break;
                case 2:
                    spawnedItem = ItemPool.areaThreeBossItems[randItemIndex];
                    break;
            }
        }
        else{
            int dropRange = (int)((float)luck * 0.25f * (1 + 0.15f * difficultyRating));
            int dropLuck = Random.Range(0, dropRange);
            int reductionRoll = Random.Range(0, 100);
            dropLuck -= reductionRoll;
            if (dropLuck < 0){
                dropLuck = 0;
            }
            switch(area){
                case 0:
                    if(dropLuck > 74){
                        dropLuck = 74;
                    }
                    randItemIndex = Random.Range(dropLuck, 124);
                    spawnedItem = ItemPool.areaOneItems[randItemIndex];
                    break;
                case 1:
                    if(dropLuck > 86){
                        dropLuck = 86;
                    }
                    randItemIndex = Random.Range(dropLuck, 143);
                    spawnedItem = ItemPool.areaTwoItems[randItemIndex];
                    break;
                case 2:
                    if(dropLuck > 93){
                        dropLuck = 93;
                    }
                    randItemIndex = Random.Range(dropLuck, 155);
                    spawnedItem = ItemPool.areaThreeItems[randItemIndex];
                    break;
            }
        }
        switch(spawnedItem.rarity){
            case "Common":
                if(!commonToggle.isOn){
                    return false;
                }
                break;
            case "Uncommon":
                if(!uncommonToggle.isOn){
                    return false;
                }
                break;
            case "Relic":
                if(!relicToggle.isOn){
                    return false;
                }
                break;
            case "Mythical":
                if(!mythicalToggle.isOn){
                    return false;
                }
                break;
            case "Legendary":
                if(!legendaryToggle.isOn){
                    return false;
                }
                break;
            case "Divine":
                if(!divineToggle.isOn){
                    return false;
                }
                break;
        }
        prefabStringNeeded = spawnedItem.rarity + spawnedItem.itemSlot;
        GameObject prefabNeeded = (GameObject)Resources.Load(prefabStringNeeded, typeof(GameObject));
        nextSlot = firstSlotOpen.gameObject;
        firstSlotOpen.itemInSlot = spawnedItem;
        var prefabInstance = Instantiate(prefabNeeded, nextSlot.transform.parent);
        prefabInstance.GetComponent<RectTransform>().position = nextSlot.transform.position;
        prefabInstance.GetComponent<DragDrop>().orgInvSlot = firstSlotOpen;
        DroppedItem droppedItem = prefabInstance.GetComponent<DroppedItem>();
        droppedItem.itemName = spawnedItem.itemName;
        droppedItem.hpStat = spawnedItem.hpStat;
        droppedItem.attackStat = spawnedItem.attackStat;
        droppedItem.defenseStat = spawnedItem.defenseStat;
        droppedItem.speedStat = spawnedItem.speedStat;
        droppedItem.luckStat = spawnedItem.luckStat;
        droppedItem.isMagic = spawnedItem.isMagic;
        droppedItem.rarity = spawnedItem.rarity;
        droppedItem.itemSlot = spawnedItem.itemSlot;
        return true;
    }

    public bool isThereRoom(){
        updateSlotsLeft();
        firstSlotOpen = allSlots[firstSlotOpenIndex];
        if(slotsLeft > 0){
            return true;
        }
        return false;
    }
}
