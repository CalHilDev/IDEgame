using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnswerSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] public string correctValue;
    public string currentValue;
    public void OnDrop(PointerEventData eventData)
    {
        if(transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
            draggableItem.parentAfterDrag = transform;
            //Debug.Log(draggableItem.tag);
            currentValue = draggableItem.tag;
            if(currentValue == correctValue)
            {
                Debug.Log("correct");
            }
        }    
    }
}
