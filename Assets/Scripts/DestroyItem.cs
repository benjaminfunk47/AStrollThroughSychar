using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DestroyItem : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData){
        if (eventData.button == PointerEventData.InputButton.Left && Input.GetKey(KeyCode.LeftShift))
        {
            Destroy(this.transform.gameObject);
            List<RaycastResult> raycastResults = new List<RaycastResult>();
            EventSystem.current.RaycastAll(eventData, raycastResults);
            int index = 0;
            for(int i = 0; i < raycastResults.Count; i++){
                if(raycastResults[i].gameObject.tag == "InventorySlot"){
                    index = i;
                    RaycastResult result = raycastResults[index];
                    result.gameObject.GetComponent<InventorySlot>().RemoveItem();
                }
                if(raycastResults[i].gameObject.tag == "EquipmentSlot"){
                    index = i;
                    RaycastResult result = raycastResults[index];
                    result.gameObject.GetComponent<EquipmentSlot>().RemoveItem();
                }
            }
        }
    }
}
