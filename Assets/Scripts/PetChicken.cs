using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PetChicken : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        gameObject.GetComponent<ChickenAnimation>().playAnim = true;
        eventData.pointerDrag.SetActive(false);
    }
}
