using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IDropHandler
{
     [SerializeField] private AudioSource _source;
    [SerializeField] private string slotID;
    private Dictionary<string, List<string>> validMatches = new Dictionary<string, List<string>>()
    {
        { "green", new List<string> { "banana" } },
        { "blue", new List<string> { "paper" } },
        { "yellow", new List<string> { "plastic" } }
    };
    public void OnDrop(PointerEventData eventData)
    {
        /*Debug.Log("On Drop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }*/
        GameObject dropped = eventData.pointerDrag;
        if (dropped == null) return;

        DragDrop dragDrop = dropped.GetComponent<DragDrop>();
        if (dragDrop == null) return;

        Debug.Log($"Trying to drop {dragDrop.itemID} into {slotID}");

        if (validMatches.ContainsKey(slotID) && validMatches[slotID].Contains(dragDrop.itemID))
        {
            Debug.Log("✅ Correct match!");
            dragDrop.droppedInCorrectSlot = true;
            dropped.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            // Prevent further dragging
            dragDrop.droppedInCorrectSlot = true;
            dragDrop.enabled = false;
            _source.Play();
            PointManager.Instance.AddPoint(); //Add a point
        }
        else
        {
            Debug.Log("❌ Incorrect match!");
            dragDrop.ResetPosition();
        }
    
    }
}
