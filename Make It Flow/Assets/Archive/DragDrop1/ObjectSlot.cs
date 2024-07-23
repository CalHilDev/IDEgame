using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectSlot : MonoBehaviour, IDropHandler
{
    public DragDrop dragDrop;
    public CorrectCheck correctCheck;

    private void Start()
    {
        dragDrop = FindObjectOfType<DragDrop>();
        correctCheck = FindObjectOfType<CorrectCheck>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("OnDrop");
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            Debug.Log(dragDrop.componentType);
            correctCheck.GetCurrentValue(dragDrop.componentType);
            //allows component to snap to item slot - checks the type assigned to component
        }
        
    }
}
