using UnityEngine;
using System.Collections.Generic;
public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public List<GameObject> inventoryUIButtons = new List<GameObject>();


    private void OnEnable() 
    {
        RefreshInventory();
    
    }

     void RefreshInventory() 
    
    {
        Debug.Log("Item count: " + inventory.items.Count);
        Debug.Log("UI Refreshing");
        foreach (GameObject uiButton in inventoryUIButtons) 
        {
        uiButton.SetActive(false);
        }
    for (int i = 0; i < inventory.items.Count; i++) 
        {
            if (i < inventoryUIButtons.Count) 
            {
              
                //if (item == null)
                //{
                //    // Go to the next iteration without setting up this button
                //    continue;
                //}
                InventoryUIButton uiButton = inventoryUIButtons[i].GetComponent<InventoryUIButton>();
                ItemObject item = inventory.items[i];
                uiButton.gameObject.SetActive(true);
                uiButton.SetButton(item);
            
            
            }
        
        }


    }

    public void OnInventoryUIButton(int i)
    {
        //if (i < inventory.items.Count && inventory.items[i] != null)
        //{
        //    inventory.removeItems(i);
        //}
        inventory.removeItems(i);

        // inventory.removeItems(i);
        RefreshInventory();
      
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
