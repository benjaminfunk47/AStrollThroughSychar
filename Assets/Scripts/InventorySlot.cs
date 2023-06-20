using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public Item itemInSlot;
    private DroppedItem di;
    private bool accepting;
    private DragDrop dd;

    private void Awake(){
        itemInSlot = null;
    }

    public void OnDrop(PointerEventData eventData){
        if (eventData.pointerDrag != null){
            dd = eventData.pointerDrag.GetComponent<DragDrop>();
            if(itemInSlot == null){
                dd.didItemHit = true;
                dd.hitTag = "InventorySlot";
                dd.newInvSlot = this;
                RectTransform itemRectTransform = eventData.pointerDrag.GetComponent<RectTransform>();
                itemRectTransform.position = GetComponent<RectTransform>().position;
                itemRectTransform.transform.SetParent(transform.parent, true);
                di = eventData.pointerDrag.GetComponent<DroppedItem>();
                itemInSlot = new Item(di.itemName, di.hpStat, di.attackStat, di.defenseStat, di.speedStat, di.luckStat, di.isMagic, di.rarity, di.itemSlot);
                return;
            }
        }
    }

    public void RemoveItem(){
        itemInSlot = null;
    }
}
