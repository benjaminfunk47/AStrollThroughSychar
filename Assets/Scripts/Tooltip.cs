using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tooltip : MonoBehaviour
{    

    public static Tooltip Instance { get; private set; }

    [SerializeField]private Camera uiCamera;
    [SerializeField]private RectTransform canvasRectTransform;

    private TextMeshProUGUI textMeshPro;
    private RectTransform backgroundRectTransform;
    private RectTransform rectTransform;
    private bool isHidden;

    private void Awake(){
        Instance = this;

        backgroundRectTransform = transform.Find("Background").GetComponent<RectTransform>();
        textMeshPro = transform.Find("Text").GetComponent<TextMeshProUGUI>();
        rectTransform = transform.GetComponent<RectTransform>();
        HideTooltipStatic();
    }

    private void SetText(string tooltipText){
        textMeshPro.SetText(tooltipText);
        textMeshPro.ForceMeshUpdate();

        Vector2 textSize = textMeshPro.GetRenderedValues(false);
        Vector2 paddingSize = new Vector2(20f, 20f);
        backgroundRectTransform.sizeDelta = textSize + paddingSize;
    }

    private void Update(){
        if(!isHidden){
            Vector2 localPoint;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent.GetComponent<RectTransform>(), Input.mousePosition, uiCamera, out localPoint);
            if(localPoint.x + backgroundRectTransform.rect.width > 960f){
                localPoint.x = 960f - backgroundRectTransform.rect.width;
            }
            if(localPoint.y + backgroundRectTransform.rect.height > 540f){
                localPoint.x += 10f;
                localPoint.y = localPoint.y - backgroundRectTransform.rect.height - 20f;
            }
            transform.localPosition = localPoint + new Vector2(5f, 5f);
        }
    }

    private void ShowTooltip(string tooltipText){
        isHidden = false;
        SetText(tooltipText);
    }

    private void HideTooltip(){
        isHidden = true;
        transform.localPosition = new Vector2(10000f, 10000f);
    }

    public static void ShowTooltipStatic(string tooltipText){
        Instance.ShowTooltip(tooltipText);
    }

    public static void HideTooltipStatic(){
        Instance.HideTooltip();
    }
}
