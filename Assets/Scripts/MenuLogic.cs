using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLogic : MonoBehaviour
{
    public GameObject backPanel;

    public void ClickOnBackground()
    {
        backPanel.SetActive(false);
    }

    public void ClickNewPlayer()
    {
        backPanel.SetActive(true);
    }

    public void ClickCreate()
    {
        backPanel.SetActive(false);
    }
}
