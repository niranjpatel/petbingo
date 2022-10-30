using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clicker : MonoBehaviour
{
    public Logic gameLogic;
    public GameObject chicken;

    public void OnMouseDown() 
    {
        TextMeshPro textField = gameObject.GetComponent(typeof(TextMeshPro)) as TextMeshPro;
        gameLogic.TriggerClick(textField.text, gameObject);
    }
}
