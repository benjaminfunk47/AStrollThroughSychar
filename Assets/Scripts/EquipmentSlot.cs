using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EquipmentSlot : MonoBehaviour, IDropHandler
{
    public Equipment equipment;
    public Item itemInSlot;
    public string slot;
    private DroppedItem di;
    bool accepting;
    private DragDrop dd;

    private void Awake(){
        itemInSlot = null;
    }

    public void OnDrop(PointerEventData eventData){
        if (eventData.pointerDrag != null){
            dd = eventData.pointerDrag.GetComponent<DragDrop>();
            di = eventData.pointerDrag.GetComponent<DroppedItem>();
            if(itemInSlot == null && di.itemSlot == slot){
                dd.didItemHit = true;
                dd.hitTag = "EquipmentSlot";
                dd.newEquipSlot = this;
                RectTransform itemRectTransform = eventData.pointerDrag.GetComponent<RectTransform>();
                itemRectTransform.position = GetComponent<RectTransform>().position;
                itemRectTransform.transform.SetParent(this.transform.parent, true);
                itemInSlot = new Item(di.itemName, di.hpStat, di.attackStat, di.defenseStat, di.speedStat, di.luckStat, di.isMagic, di.rarity, di.itemSlot);
                if(slot == itemInSlot.itemSlot){
                    equipment.SetEquipment(itemInSlot);
                }
            }
        }
    }

    public void RemoveItem(){
        equipment.RemoveEquipment(itemInSlot.itemSlot);
        itemInSlot = null;
    }
}
