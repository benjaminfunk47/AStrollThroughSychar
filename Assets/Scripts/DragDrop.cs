using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public DroppedItem droppedItem;
    public Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector2 originalPosition;
    private EquipmentSlot orgEquipSlot;
    public InventorySlot orgInvSlot;
    public EquipmentSlot newEquipSlot;
    public InventorySlot newInvSlot;
    private bool isOrgInv;
    public bool didItemHit;
    public string hitTag;

    private void Awake(){
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = FindObjectOfType<Canvas>();        
        didItemHit = false;
        isOrgInv = true;
    }

    public void OnBeginDrag(PointerEventData eventData){
        originalPosition = rectTransform.position;
        canvasGroup.alpha = .6f;        
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData){
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData){
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        if(Math.Abs(rectTransform.position.x) >= 960 || Math.Abs(rectTransform.position.y) >= 540){
            rectTransform.position = originalPosition;
            return;
        }
        if(didItemHit){
            if(hitTag == "InventorySlot"){
                if(!isOrgInv){
                    orgEquipSlot.RemoveItem();
                    orgInvSlot = newInvSlot;
                    orgEquipSlot = null;
                    newInvSlot = null;
                    isOrgInv = true;
                }
                else if(orgInvSlot == newInvSlot){
                    rectTransform.position = originalPosition;
                }
                else{
                    orgInvSlot.RemoveItem();
                    orgInvSlot = newInvSlot;
                    newInvSlot = null;
                    isOrgInv = true;
                }
            }
            if(hitTag == "EquipmentSlot"){
                if(newEquipSlot.slot != droppedItem.itemSlot){
                    rectTransform.position = originalPosition;
                }
                else{
                    if(isOrgInv){
                        orgInvSlot.RemoveItem();
                        orgEquipSlot = newEquipSlot;
                        newEquipSlot = null;
                        isOrgInv = false;
                    }
                    else{
                        rectTransform.position = originalPosition;
                    }
                }
            }
        }
        else{
            rectTransform.position = originalPosition;
        }
        didItemHit = false;
    }
}
