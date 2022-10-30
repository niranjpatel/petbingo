using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyScript : MonoBehaviour
{
    public GameObject difficultyDialog;
    public void ShowDifficultyDialog()
    {
        difficultyDialog.SetActive(true);
    }

    public void HideDialog()
    {
        difficultyDialog.SetActive(false);
    }

    public void ClickEasy()
    {
       SceneManager.LoadScene("GameScene"); 
    }
}
