using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Inventory Inventory;

    void Start()
    {
        Inventory.ItemAdded += InventoryScript_ItemAdded;    
    }
}
