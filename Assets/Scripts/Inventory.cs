using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;


public class Inventory : MonoBehaviour
{
    public List<string> items = new List<string>();
    public GameManager gameManager;

   public void AddItems(string itemName) 
    {
      
            items.Add(itemName);
        
       
    }

    public void removeItems(string itemName) 
    {
        if (items.Contains(itemName)) 
        {
        items.Remove(itemName);
        }
        else {
            Console.WriteLine("Item not found");
        
        }
    
    }

   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //AddItems("health");
        //Console.WriteLine(items[1]);
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //gameManager.state==GameManager.GameState.GAMEPLAY


        if (gameManager.state == GameState.GAMEPLAY)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                AddItems("Generic Item");
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                removeItems("Generic Item");
            }
        }


    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        ItemObject collisionItem = hit.gameObject.GetComponent<ItemObject>();
        if (collisionItem != null) 
        {
            AddItems(collisionItem.ItemName);
            Console.WriteLine("Hit");
            Destroy(collisionItem.gameObject);
        }

    }
}
