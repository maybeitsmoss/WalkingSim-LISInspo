using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class InventoryScript : MonoBehaviour
{

    public itemScript item;

    [Header("UI")]
    public Image image;

    public void InitalizeItem(itemScript newItem)
    {
        image.sprite = newItem.image;

    }



}
    // Start is called once before the first execution of Update after the MonoBehaviour is creat